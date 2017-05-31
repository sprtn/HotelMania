using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Xml.Linq;

namespace HotelMania
{
	public partial class HotelMania : Form
	{
		public Hotel theHotel;
		DateTime dummyTimeStamp = DateTime.Now;

        List<HotelRoom> listOfRooms = new List<HotelRoom>();
		BindingList<Guest> listOfGuestsWithoutRooms = new BindingList<Guest>();
        BindingList<Guest> listOfGuestsWithRooms = new BindingList<Guest>();
		BindingList<HotelRoom> floor1 = new BindingList<HotelRoom>();
		BindingList<HotelRoom> floor2 = new BindingList<HotelRoom>();
		BindingList<HotelRoom> floor3 = new BindingList<HotelRoom>();

		/* Drag & Drop */
		private Rectangle dragBoxFromMouseDown;
		private object valueFromMouseDown;

		int availableRoomsFloor(BindingList<HotelRoom> floor)
		{
			int numOccupiedRooms = 0;
			foreach (HotelRoom r in floor)
			{
				if (!r.isNotOccupied)
					numOccupiedRooms++;
			}
			return numOccupiedRooms;
		}

		short numTimes;

		/* Constructor */
		public HotelMania()
		{
            theHotel = new Hotel();

			InitializeComponent();

			addFloorToList(floor1, 1);
			addFloorToList(floor2, 2);
			addFloorToList(floor3, 3);

			guestListDataGrid.DataSource = listOfGuestsWithoutRooms;
			dataGridViewFloor1.DataSource = floor1;
			dataGridViewFloor2.DataSource = floor2;
			dataGridViewFloor3.DataSource = floor3;

			TryLoadData();
			refreshAll();
		}

        private BindingList<HotelRoom> findRightBindingList(Guest g)
        {
            if (g != null && g.hasRoom)
            {
                switch (g.FloorNumber)
                {
                    case 1:
                        return floor1;
                    case 2:
                        return floor2;
                    case 3:
                        return floor3;
                    default:
                        return null;
                }
            }
            else
                return null;
        }

		private void addFloorToList(BindingList<HotelRoom> bindlist, int v)
		{
			foreach (HotelRoom _curRoom in theHotel.listOfFloors.ToArray().ElementAt(v - 1).listOfRooms)
				bindlist.Add(_curRoom);		
		}

		private void addGuest(string v, DateTime dummyTimeStamp2)
		{
			listOfGuestsWithoutRooms.Add(new Guest(v, dummyTimeStamp, dummyTimeStamp2));
		}

		private void submitNewGuestButton_Click(object sender, EventArgs e)
		{
			submitGuestInput();
		}

		private void submitGuestInput()
		{
			listOfGuestsWithoutRooms.Add(new Guest(inputFieldName.Text, dummyTimeStamp, DateTime.Now));
			inputFieldName.Clear();
		}

		private void inputFieldName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				submitGuestInput();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            if ( tabControl1.SelectedIndex == 0 )
            {
                if (guestListDataGrid.CurrentRow != null)
                    numTimes++;
				if (numTimes >= 2)
                {
                    if (guestListDataGrid.CurrentRow != null && guestListDataGrid.CurrentRow.DataBoundItem != null)
                    {
                        listOfGuestsWithoutRooms.Remove(curGuest());
						if (curGuest() != null)
							curGuest().RemoveRoom();
                        guestListDataGrid.DataSource = listOfGuestsWithoutRooms;
                    }
                }
				resetNumTimes();
			}
            else
            {
                if (dataGridViewGuestsWithRooms.CurrentRow != null)
                    numTimes++;
                if (numTimes >= 2)
                {
                    if ((Guest)dataGridViewGuestsWithRooms.CurrentRow.DataBoundItem != null)
                    {
                        Guest g = (Guest)dataGridViewGuestsWithRooms.CurrentRow.DataBoundItem;
                        listOfGuestsWithRooms.Remove(g);
                        g.RemoveRoom();
                    }
                }
				resetNumTimes();
			}
		}

		private async void resetNumTimes()
		{
			await Task.Delay(1000);
			numTimes = 0;
		}

		public int CurrentTab()
		{
			return tabControl.SelectedIndex;
		}
		public BindingList<HotelRoom> getCurrList()
		{
			switch (CurrentTab())
			{
				case 1:
					return floor1;
				case 2:
					return floor2;
				case 3:
					return floor3;
                default:
                    return null;
			}
		}
		public DataGridView getCurrDataGrid()
		{
			switch (CurrentTab())
			{
				case 1:
					return dataGridViewFloor1;
				case 2:
					return dataGridViewFloor2;
				case 3:
					return dataGridViewFloor3;
                default:
                    return null;
            }
		}

        private void button1_Click(object sender, EventArgs e)
        {
            if (curGuest() != null && curRoom() != null && curRoom().isNotOccupied)
            {
                Guest g = curGuest();
                HotelRoom h = curRoom();

                // Assign room to guest and guest to room.
                h.SetOccupant(g);
                g.AssignRoom(h);

                listOfGuestsWithoutRooms.Remove(g);
                listOfGuestsWithRooms.Add(g);
            }
			UpdateVisualsInDataGridViewRow();
			refreshAll();
		}

        private void refreshAll()
        {
            dataGridViewGuestsWithRooms.DataSource = listOfGuestsWithRooms;
            guestListDataGrid.DataSource = listOfGuestsWithoutRooms;
        }

        private Guest curGuest()
        {
			try
			{
				if (guestListDataGrid.CurrentRow != null)
				{
					Guest eh = (Guest) guestListDataGrid.CurrentRow.DataBoundItem;
					return (Guest) guestListDataGrid.CurrentRow.DataBoundItem;
				} else
					return null;
			} catch {
				return null;
			}
        }

        private HotelRoom curRoom()
        {
            if (getCurrDataGrid() != null)
                if (getCurrDataGrid().CurrentRow != null)
                {
                    HotelRoom eh = (HotelRoom)getCurrDataGrid().CurrentRow.DataBoundItem;
                    return (HotelRoom)getCurrDataGrid().CurrentRow.DataBoundItem;
                }
            return null;
        }

        public static DataTable ToDataTable<T>(List<T> items)
		{
			DataTable dataTable = new DataTable(typeof(T).Name);

			//Get all the properties
			PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			foreach (PropertyInfo prop in Props)
			{
				//Defining type of data column gives proper data table 
				var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
				//Setting column names as Property names
				dataTable.Columns.Add(prop.Name, type);
			}
			foreach (T item in items)
			{
				var values = new object[Props.Length];
				for (int i = 0; i < Props.Length; i++)
				{
					//inserting property values to datatable rows
					values[i] = Props[i].GetValue(item, null);
				}
				dataTable.Rows.Add(values);
			}
			//put a breakpoint here and check datatable
			return dataTable;
		}

		private void addToList(BindingList<HotelRoom> f)
        {
            foreach (HotelRoom h in f)
                listOfRooms.Add(h);
        }

        public Hotel getHotel()
        {
            return theHotel;
        }

		private HotelRoom getRoomByFloorAndRoomNumbers(int _fNo, int _rNo)
		{
			var roomList = getFloor(_fNo - 1);
			if (roomList != null)
				return roomList.ElementAt(_rNo - 1);
			return null;
		}

		private BindingList<HotelRoom> getFloor(int fNo)
		{
			switch (fNo)
			{
				case (0):
					return floor1;
				case 1:
					return floor2;
				case 2:
					return floor3;
				default:
					return null;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (curRoom() != null && !curRoom().isNotOccupied)
			{
				Guest g = curRoom().currOccupant;
				HotelRoom h = curRoom();

				// Remove guest from room and room from guest.
				g.RemoveRoom();
				h.SetOccupant();

				listOfGuestsWithoutRooms.Add(g);
				listOfGuestsWithRooms.Remove(g);
			}
			UpdateVisualsInDataGridViewRow();
			refreshAll();
		}

		/* Drag & Drop, courtesy of https://stackoverflow.com/questions/21131157/drag-and-drop-cell-from-datagridview-to-another
		 * Can't seem to get it to work. In stackoverflow it was used for Cell values. I dont know if this is the issue.
		 */

		private void guestListDataGrid_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
				{
					DragDropEffects dropEffect = guestListDataGrid.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
				}
			}
		}

		private void guestListDataGrid_MouseDown(object sender, MouseEventArgs e)
		{
			var hittestInfo = guestListDataGrid.HitTest(e.X, e.Y);

			if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1)
			{
				valueFromMouseDown = guestListDataGrid.Rows[hittestInfo.RowIndex].DataBoundItem;
				if (valueFromMouseDown != null)
				{       
					Size dragSize = SystemInformation.DragSize;
					dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
				}
			} else
				dragBoxFromMouseDown = Rectangle.Empty;
		}

		private void guestListDataGrid_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void dataGridViewFloor1_DragDrop(object sender, DragEventArgs e)
		{
			Point clientPoint = dataGridViewFloor1.PointToClient(new Point(e.X, e.Y));
			if (e.Effect == DragDropEffects.Copy)
			{
				string cellvalue = e.Data.GetData(typeof(string)) as string;
				var hittest = dataGridViewFloor1.HitTest(clientPoint.X, clientPoint.Y);
				if (hittest.ColumnIndex != -1
					&& hittest.RowIndex != -1)
					dataGridViewFloor1[hittest.ColumnIndex, hittest.RowIndex].Value = cellvalue;
			}
		}

		private void dataGridViewFloor2_DragDrop(object sender, DragEventArgs e)
		{
			Point clientPoint = dataGridViewFloor2.PointToClient(new Point(e.X, e.Y));
			if (e.Effect == DragDropEffects.Copy)
			{
				string cellvalue = e.Data.GetData(typeof(string)) as string;
				var hittest = dataGridViewFloor2.HitTest(clientPoint.X, clientPoint.Y);
				if (hittest.ColumnIndex != -1
					&& hittest.RowIndex != -1)
					dataGridViewFloor1[hittest.ColumnIndex, hittest.RowIndex].Value = cellvalue;
			}
		}

		private void dataGridViewFloor3_DragDrop(object sender, DragEventArgs e)
		{
			Point clientPoint = dataGridViewFloor3.PointToClient(new Point(e.X, e.Y));
			if (e.Effect == DragDropEffects.Copy)
			{
				string cellvalue = e.Data.GetData(typeof(string)) as string;
				var hittest = dataGridViewFloor3.HitTest(clientPoint.X, clientPoint.Y);
				if (hittest.ColumnIndex != -1
					&& hittest.RowIndex != -1)
					dataGridViewFloor1[hittest.ColumnIndex, hittest.RowIndex].Value = cellvalue;

			}
		}

		/* Loading and saving to XML */

		private void saveData_Click(object sender, EventArgs e)
		{
			if (listOfRooms != null)
				listOfRooms.Clear();
			addToList(floor1);
			addToList(floor2);
			addToList(floor3);

			DataSet ds = new DataSet();
			ds.Tables.Add(ToDataTable(listOfRooms));
			string dsXml = ds.GetXml();
			using (StreamWriter fs = new StreamWriter("xmlFile.xml"))
				ds.WriteXml(fs);
		}

		private void loadData_Click(object sender, EventArgs e)
		{
			TryLoadData();
		}

		private void TryLoadData()
		{
			try
			{
				DataSet ds = new DataSet();
				XDocument doc = XDocument.Load("xmlFile.xml");
				listOfGuestsWithRooms = new BindingList<Guest>();

				var SavedRooms = doc.Descendants("HotelRoom");
				foreach (var r in SavedRooms)
					if (!(bool) r.Element("isNotOccupied"))
					{
						var room = getRoomByFloorAndRoomNumbers(
							int.Parse(r.Element("FloorNumber").Value),
							int.Parse(r.Element("RoomNumber").Value));

						room.SetOccupant(new Guest(
							(string) r.Element("currOccupant").Element("GuestName"),
							(DateTime) r.Element("currOccupant").Element("StayingFrom"),
							(DateTime) r.Element("currOccupant").Element("StayingTo")));
						listOfGuestsWithRooms.Add(room.currOccupant);
						room.currOccupant.setRoom = room;
					}

				/* Reset the guestlists */
				listOfGuestsWithoutRooms = new BindingList<Guest>();
			} catch (Exception xmlLoadingException)
			{
				displayForAFew(xmlLoadingException.Message, true);
			} finally
			{
				refreshAll();
			}
		}

		private async void displayForAFew(string message, bool v)
		{
			ErrorMsgLoad.Text = message;
			ErrorMsgLoad.Visible = true;

			await Task.Delay(5000);
			ErrorMsgLoad.Visible = false;
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateVisualsInDataGridViewRow();
		}

		private void UpdateVisualsInDataGridViewRow()
		{
			var curGrid = getCurrDataGrid();
			if (curGrid != null)
				foreach (DataGridViewRow item in curGrid.Rows)
				{
					if (((HotelRoom) item.DataBoundItem).isNotOccupied)
						item.DefaultCellStyle.BackColor = Color.LightGreen;
					else
						item.DefaultCellStyle.BackColor = Color.CadetBlue;
				}
			Refresh();
		}
	}
}
