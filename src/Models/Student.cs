using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]

    public class Student
    {
        public Student(string name, PetType pet)
        {
            Name = name;
            Pet = pet;
        }

        public string Name { get; set; }
        public PetType Pet { get; set; }

    }
}
