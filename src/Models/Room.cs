using System.Collections.Generic;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Room
    {
        public Room()
        {
            Students = new List<Student>();
        }

        public Room(int id, bool available)

        {
            Id = id;
            Available = available;
            Students = new List<Student>();
        }

        public int Id { get; set; }
        public bool Available { get; set; }
        public List<Student> Students { get; set; }
    }
}
