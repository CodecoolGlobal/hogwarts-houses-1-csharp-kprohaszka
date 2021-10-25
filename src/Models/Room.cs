namespace HogwartsHouses.Models
{
    [System.Serializable]

    public class Room
    {
        public int Number { get; private set; }
        public string Name { get; private set; }

        public Room(int number, string name)
        {
            Number = number;
            Name = name;
        }
    }
}
