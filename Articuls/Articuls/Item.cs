using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articuls
{
    public class Item:IComparable<Item>
    {
		private string description;
		private double price;

        public Item(string description, double price)
        {
            this.Description = description;
            this.Price = price;
        }

        public double Price
		{
			get { return price; }
			private set 
			{
				if (value<0)
				{
					throw new ArgumentException("Price can not bi negative!");
				}
				price = value;
			}
		}
		public string Description
		{
			get { return description; }
			private set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException();
				}
				description = value; 
			}
		}

        public int CompareTo(Item? other)
        {
			if (description.CompareTo(other.Description)<0)
			{
				return 1;
			}
            if (description.CompareTo(other.Description) == 0)
            {
				if (price.CompareTo(other.Price)<0)
				{
					return 1;
				}
				return 0;
            }
			return -1; ;
        }//end 1
        public override string ToString()
        {
            return $"{Description} ({Price:f2})";
        }
    }
}
