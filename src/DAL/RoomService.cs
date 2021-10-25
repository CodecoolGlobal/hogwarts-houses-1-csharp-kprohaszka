using HogwartsHouses.Models;

namespace HogwartsHouses.DAL
{
    public class RoomService : IRoomService
    {
        private IRepository<Room> _repository { get; }

        public RoomService(IRepository<Room> repository)
        {
            _repository = repository;
        }

        public Room createRoom()
        {
            var room = new Room(5, "Room1");
            return room;
        }

    }
}
