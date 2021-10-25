using HogwartsHouses.Models;
using System.Collections.Generic;

namespace HogwartsHouses.DAL
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAllRooms();
        public void Add(T room);
        Room GetRoomById(int id);
        void DeleteRoomByRoomId(int id);
        void UpdateRoomById(int id, Room room);
        public IEnumerable<T> GetAviableRooms();




        IEnumerable<Room> GetAllRoomsWithoutCatsOrOwls();
    }
}
