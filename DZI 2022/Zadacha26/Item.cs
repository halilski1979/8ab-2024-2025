using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha26
{
    public class Item :IComparable<Item>
    {
		private string description;
        private double price;
        public Item(string description, double price)
        {
            Description = description;
            Price = price;

        }
        public string Description
		{
			get { return description; }
			private set 
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new ArgumentException("The description must contain a character");
				}
				
				description = value; 
			}
		}
        public double Price
		{
			get { return price; }
			private set 
			{
				if (value<0)
				{
                    throw new ArgumentException("The price must be a positive number");
                }
				price = value; 
			}
		}
        public int CompareTo(Item? other)
        {
            if (other==null)
            {
				return 1;
            }
            if (description.CompareTo(other.Description)==0||description.CompareTo(other.Description)<0)
			{
				if (price < other.Price)
				{
					return 1;
				}
				else if (price > other.Price)
				{ 
				  return -1;
				
				}
				return 0;
			}
			return -1;


        }
        public override string ToString()
        {
            return $"{description}: {price:f2}";
        }
    }
}
