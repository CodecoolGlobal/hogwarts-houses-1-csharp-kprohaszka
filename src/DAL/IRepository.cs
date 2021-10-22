using HogwartsHouses.Models;
using System.Collections.Generic;

namespace HogwartsHouses.DAL
{
    public interface IRepository<T>
    {
        public IEnumerable<Room> GetAll();
    }
}
