using HogwartsHouses.DAL;
using HogwartsHouses.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HogwartsHouses.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller

    {

        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IEnumerable<Room> GetAllRooms()
        {
            var rooms = _roomService.GetAll();
            return rooms;
        }

        [HttpPost]
        public void AddNewRoom([FromBody] Room room)
        {
            _roomService.AddNewRoom(room);
        }

        //api/room/{roomId}
        [HttpGet("{id}")]
        public Room GetRoomById(int id)
        {
            Room room = _roomService.GetRoomById(id);
            return room;
        }

        [HttpGet("available")]

        public IEnumerable<Room> GetAviableRooms()
        {
            var rooms = _roomService.GetAviableRooms();
            return rooms;
        }

        [HttpDelete("{id}")]
        public void DeleteRoomById(int id)
        {
            _roomService.DeleteRoomById(id);
        }

        [HttpPut("{id}")]
        public void UpdateRoomById(int id, [FromBody] Room room)
        {
            _roomService.UpdateRoomById(id, room);
        }
    }
}
