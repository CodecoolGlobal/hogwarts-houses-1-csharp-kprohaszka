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

        public void StarterListOfStudents()
        {
            Students.Add(new Student("Hermione Granger", PetType.Cat));
            Students.Add(new Student("Draco Malfoy", PetType.None));
        }

        public void NewRoomsForStudents()
        {
            Rooms.Add(new Room(1, true));
            Rooms.Add(new Room(2, true));
            Rooms.Add(new Room(3, true));
        }

        public void AssignStudentToRoom(Student student, Room room)
        {
            foreach (var roomInRooms in Rooms)
            {
                if (roomInRooms == room && roomInRooms.Available)
                {
                    room.Students.Add(student);
                    room.Available = false;
                    Rooms.Remove(roomInRooms);
                    Rooms.Add(room);
                    break;
                }
            }
        }

        public void Initialize()
        {
        }
    }
}
