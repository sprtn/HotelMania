using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMania
{
	public class Floor
	{
		public List<HotelRoom> listOfRooms = new List<HotelRoom>();

		public Floor(int _floorNumber, int _roomsOnTheFloor)
		{
			for (int i = 1; i <= _roomsOnTheFloor; i++)
				listOfRooms.Add(new HotelRoom(i, _floorNumber));
		}
	}
}
