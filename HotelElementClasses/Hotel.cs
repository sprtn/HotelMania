using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMania
{
	public class Hotel
	{
		public const int numberOfRooms = 14, numberOfFloors = 3;
		public List<Floor> listOfFloors = new List<Floor>();

        /// <summary>
        /// Constructor function for the Hotel class.
        /// </summary>
		public Hotel()
		{
			for (int i = 1; i <= numberOfFloors; i++)
				listOfFloors.Add(new Floor(i, numberOfRooms));
		}
	}
}
