using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha26
{
    public class ItemList
    {
        private readonly List<Item> items;

        public ItemList()
        {
            this.items = new List<Item>();
        }

        public int Count()=>items.Count;

        public Item Get(int index)
        {
            if (index<0||index>items.Count-1)
            {
                throw new ArgumentException("Oustside of range");
            }
            return items[index];
        }
        public void Add(Item item) 
        {
            if (items.Contains(item))
            {
                throw new ArgumentException("Item already exists");
            }
           items.Add(item);
            items.Sort();
 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Item item in items) 
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
