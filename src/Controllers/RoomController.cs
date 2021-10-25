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
    }
}
