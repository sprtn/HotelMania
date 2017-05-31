using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMania
{
	public class HotelRoom
	{
		/// <summary>
		/// The number of the room on the designated floor
		/// </summary>
		public int RoomNumber { get; set; }

		/// <summary>
		/// The number of the floor the room is on
		/// </summary>
		public int FloorNumber { get; set; }

        /// <summary>
        /// The current Guest occupying the room
        /// </summary>
		public Guest currOccupant { get; set; }

        /// <summary>
        /// The name of the guest. Returns null if there is no guest present.
        /// </summary>
        public string nameOfOccupant
        {
            get
            {
                if (!isNotOccupied)
                    return currOccupant.GuestName;
                return null;
            }
        }

        /// <summary>
        /// Whether or not there is a guest bound to the room.
        /// </summary>
		public bool isNotOccupied
		{
			get {
				if (currOccupant == null)
					return true;
				return false;
			}
		}

		/// <summary>
		/// A list of dates the room is occupied
		/// </summary>
		public List<DateTime> datesOccupied;

		/// <summary>
		/// Constructor function for the HotelRoom which takes two ints as params
		/// </summary>
		/// <param name="_roomNumber"> The number of the room on the designated floor </param>
		/// <param name="_floorNumber"> The number of the floor the room is on </param>
		public HotelRoom (int _roomNumber, int _floorNumber)
		{
			RoomNumber = _roomNumber;
			FloorNumber = _floorNumber;
		}

        /// <summary>
        /// Set the input occupant as the current guest.
        /// </summary>
        /// <param name="guest"></param>
		public void SetOccupant(Guest guest)
		{
			currOccupant = guest;
		}

        /// <summary>
        /// Sets the current guest to null.
        /// </summary>
		public void SetOccupant()
		{
			currOccupant = null;
		}
	}
}
