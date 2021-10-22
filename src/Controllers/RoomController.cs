
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
        private readonly IRepository<Room> _repository;

        public RoomController(IRepository<Room> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Room> GetAllRooms()
        {
            var rooms = _repository.GetAll();
            return rooms;
        }
    }
}
