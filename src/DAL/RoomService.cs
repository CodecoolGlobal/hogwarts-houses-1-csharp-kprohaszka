using HogwartsHouses.Models;
using System.Collections.Generic;

namespace HogwartsHouses.DAL
{
    public class RoomService : IRoomService
    {
        private IRepository<Room> _repository { get; }

        public RoomService(IRepository<Room> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Room> GetAll()
        {
            return _repository.GetAllRooms();
        }

        public void AddNewRoom(Room room)
        {
            _repository.Add(room);
        }

        public Room GetRoomById(int id)
        {
            return _repository.GetRoomById(id);
        }

        public IEnumerable<Room> GetAviableRooms()
        {
            return _repository.GetAviableRooms();
        }

        public void DeleteRoomById(int id)
        {
            _repository.DeleteRoomByRoomId(id);
        }

        public void UpdateRoomById(int id, Room room)
        {
            _repository.UpdateRoomById(id, room);
        }

        public IEnumerable<Room> GetAllRoomsWithoutCatsOrOwls()
        {
            return _repository.GetAllRoomsWithoutCatsOrOwls();
        }
    }
}