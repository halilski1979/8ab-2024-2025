using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articuls
{
    public class ItemList
    {
        private List<Item> items;
        public ItemList()
        {
            this.items = new List<Item>();    
        }
        //Methods
        public int Size()
        {
            return this.items.Count;
        }//end1
        public Item Get(int index) 
        {
            if (index<0||index>items.Count-1)
            {
                throw new ArgumentException();
            }
         return items[index];
        }//end2
        public void Add(Item item) 
        { 
            items.Add(item);
            items.Sort();
        }//end3

    }
}
