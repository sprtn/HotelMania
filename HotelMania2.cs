using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMania
{
	public partial class HotelMania : Form
	{
		Hotel h = new Hotel();

		BindingList<Guest> guestList = new BindingList<Guest>();
		BindingList<HotelRoom> floor1 = new BindingList<HotelRoom>();
		BindingList<HotelRoom> floor2 = new BindingList<HotelRoom>();
		BindingList<HotelRoom> floor3 = new BindingList<HotelRoom>();
		DateTime dummyTimeStamp = DateTime.Now;

		public HotelMania()
		{
			addDummies();
			InitializeComponent();
			h = new Hotel();

			addFloorToList(floor1, 1);
			addFloorToList(floor2, 2);
			addFloorToList(floor3, 3);

			guestListDataGrid.DataSource = guestList;
			dataGridViewFloor1.DataSource = floor1;
			dataGridViewFloor2.DataSource = floor2;
			dataGridViewFloor3.DataSource = floor3;
		}

		private void addFloorToList(BindingList<HotelRoom> bindlist, int v)
		{
			foreach (HotelRoom _curRoom in h.listOfFloors.ToArray().ElementAt(v - 1).listOfRooms)
				bindlist.Add(_curRoom);		
		}

		private void addDummies()
		{
			List<String> dummies = new List<string> {
				"Per",
				"Pål",
				"Knut",
				"Roar",
				"Helen",
				"Svein",
				"Madeleine",
				"Emma"
			};

			foreach (String dummyGuest in dummies)
			{
				addTestGuest(dummyGuest, DateTime.Now);
			}
		}

		private void addTestGuest(string v, DateTime dummyTimeStamp2)
		{
			guestList.Add(new Guest(v, dummyTimeStamp, dummyTimeStamp2));
		}

		private void submitNewGuestButton_Click(object sender, EventArgs e)
		{
			guestList.Add(new Guest(inputFieldName.Text, dummyTimeStamp, DateTime.Now));

			inputFieldName.Clear();
		}
	}
}
