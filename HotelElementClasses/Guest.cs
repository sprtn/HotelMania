using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMania
{
	public class Guest
	{
		/// <summary>
		/// The name of the Guest in question.
		/// </summary>
		public string GuestName { get; set; }

		/// <summary>
		/// The HotelRoom that has been assigned to the Guest, if any.
		/// </summary>
		private HotelRoom BookedRoom;

		/// <summary>
		/// The date the guest has booked a room from
		/// </summary>
		public DateTime StayingFrom;

		/// <summary>
		/// The date the guest will be leaving
		/// </summary>
		public DateTime StayingTo;

        /// <summary>
        /// This returns the room of the guest.
        /// </summary>
        public HotelRoom getRoom
        {
            get
            {
                if (BookedRoom != null)
                    return BookedRoom;
                return null;
            }
        }

		public HotelRoom setRoom
		{
			set {
				BookedRoom = value;
			}
		}

        /// <summary>
        /// The number of the floor the guest will be staying in
        /// </summary>
        public int FloorNumber
		{
			get
			{
				if (hasRoom)
					return BookedRoom.FloorNumber;
				return 0;
			}
		}

		/// <summary>
		/// The number of the room the guest will be staying in
		/// </summary>
		public int RoomNumber
		{
			get
			{
				if (hasRoom)
					return BookedRoom.RoomNumber;
				return 0;
			}
		}

		/// <summary>
		/// Whether the guest has been assigned a room to stay in
		/// </summary>
		public bool hasRoom
		{
			get
			{
				if (BookedRoom != null)
					return true;
				return false;
			}
		}

		/// <summary>
		/// The constuctor function for the Guest. Takes a guest name, when the guest is arriving and when the guest is leaving as parameters.
		/// </summary>
		/// <param name="_guestName"> The name of the guest. </param>
		/// <param name="_stayingFrom"> The date the guest is checking in. </param>
		/// <param name="_stayingTo"> The date the guest is checking out. </param>
		public Guest (string _guestName, DateTime _stayingFrom, DateTime _stayingTo)
		{
			GuestName = _guestName;
			StayingFrom = _stayingFrom;
			StayingTo = _stayingTo;
		}

		public Guest()
		{
			// de nada?
		}

		/// <summary>
		/// Assigns the input room to the Guest if it is available and a valid room.
		/// </summary>
		/// <param name="_room">The room you are trying to assign to the guest</param>
		public void AssignRoom(HotelRoom _room)
		{
			if (_room != null && _room.isNotOccupied /* And logic for checking whether the room is available between StayingFrom to StayingTo */)
                if (_room.isNotOccupied == true)
                {
                    _room.SetOccupant(this);
                    BookedRoom = _room;
                }
		}

		/// <summary>
		/// Removes the room from the Guest
		/// </summary>
		public void RemoveRoom()
		{
			if (BookedRoom != null)
				BookedRoom = null;
		}

		/// <summary>
		/// Changes the date of the order from the current dates to the input dates.
		/// </summary>
		/// <param name="_stayingFrom"> The date the guest checks in </param>
		/// <param name="_stayingTo"> The date the guest checks out </param>
		public void ChangeOrderDate(DateTime _stayingFrom, DateTime _stayingTo)
		{
			StayingFrom = _stayingFrom;
			StayingTo = _stayingTo;
			// Add logic that checks whether the room is occupied in that timespan. If it is, throw a message saying that the room has been unassigned and unassign the room.
		}

		/// <summary>
		/// If only one of the two dates are to be changed.
		/// </summary>
		/// <param name="date"></param>
		/// <param name="_FromDateOrToDate"></param>
		public void ChangeOrderDate(DateTime date, short _FromDateOrToDate)
		{
			switch (_FromDateOrToDate)
			{
				case 1:
					StayingFrom = date;
					break;
				case 2:
					StayingTo = date;
					break;
				default:
					// Send an error message
					break;
			}
		}
	}
}
