using HogwartsHouses.Models;
using System.Collections.Generic;

namespace HogwartsHouses.DAL
{
    public interface IRoomService
    {
        public IEnumerable<Room> GetAll();
        public void AddNewRoom(Room room);
        Room GetRoomById(int id);
        void DeleteRoomById(int id);
        void UpdateRoomById(int id, Room room);
        public IEnumerable<Room> GetAviableRooms();
        IEnumerable<Room> GetAllRoomsWithoutCatsOrOwls();
    }
}
