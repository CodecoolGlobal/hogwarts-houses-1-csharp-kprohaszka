using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HogwartsHouses.DAL

// use this so the controller wont be dependent on the data access layer
{
    public class RoomRepository : IRepository<Room>
    {
        private RoomSampler _roomSampler { get; }

        public RoomRepository()
        {
            _roomSampler = new RoomSampler();
        }

        public IEnumerable<Room> GetAllRooms()
        {

            return _roomSampler.Rooms;
        }

        public void Add(Room room)
        {
            _roomSampler.Rooms.Add(room);
        }

        public Room GetRoomById(int id)
        {
            foreach (var room in _roomSampler.Rooms)
            {
                if (room.Id == id)
                {
                    return room;
                }
            }

            return null;
        }

        public IEnumerable<Room> GetAviableRooms()
        {
            return _roomSampler.Rooms.Where(x => x.Available == true);
        }

        public void DeleteRoomByRoomId(int id)
        {
            _roomSampler.Rooms.RemoveWhere(room => room.Id == id);
        }

        public void UpdateRoomById(int id, Room room)
        {
            _roomSampler.Rooms.RemoveWhere(room => room.Id == id);
            _roomSampler.Rooms.Add(room);
        }

        public IEnumerable<Room> GetAllRoomsWithoutCatsOrOwls()
        {
            List<Room> roomsWithoutCatsOrOwls = new List<Room>();
            foreach (var room in _roomSampler.Rooms)
            {
                bool isRoomWithoutCatsOrOwls = true;
                foreach (var student in room.Students)
                {
                    if (student.Pet == PetType.Owl || student.Pet == PetType.Cat)
                    {
                        isRoomWithoutCatsOrOwls = false;
                    }
                }
                if (isRoomWithoutCatsOrOwls)
                {
                    roomsWithoutCatsOrOwls.Add(room);
                }
            }
            return roomsWithoutCatsOrOwls;
        }
    }
}
