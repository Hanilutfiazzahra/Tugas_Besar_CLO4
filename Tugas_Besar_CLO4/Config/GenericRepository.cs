using System;
using System.Collections.Generic;
using System.Linq;

namespace Tugas_Besar_CLO4.Config
{
    public class GenericRepository<T>
    {
        private List<T> items = new();

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll()
        {
            return items;
        }

        public List<T> Find(Func<T, bool> predicate)
        {
            return items.Where(predicate).ToList();
        }
    }
}