using System;
using System.Collections.Generic;
using System.Linq;
using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.DAL
{
    public class RoomSampler
    {
        public HashSet<Room> Rooms { get; private set; }
        public List<Student> Students { get; private set; }
        public object PetTypes { get; private set; }

        public RoomSampler()
        {
            Rooms = new HashSet<Room>();
            Students = new List<Student>();
            Initialize();
        }

        public void Initialize()
        {
        }
    }
}
