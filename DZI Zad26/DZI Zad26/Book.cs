using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZI_Zad26
{
    public class Book:IComparable<Book>
    {
		private string title;
		private int pages;

        public Book(string title, int pages)
        {
            this.Title = title;
            this.Pages = pages;
        }
        public int Pages
		{
			get { return pages; }
			private set 
			{
				if (value<=0)
				{
					throw new ArgumentException("The pages can bi positiv number");
				}
				pages = value; 
			}
		}
		public string Title
		{
			get { return title; }
			private set 
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("The title is not emty string!");
				}
				title = value; 
			}
		}
        public int CompareTo(Book? other)
        {
			var compare = title.CompareTo(other.Title);
			if (compare!=0)
			{
				return compare;
			}
			return pages.CompareTo(other.Pages);
        }
        public override string ToString()
        {
            return $"{this.Title} [{this.Pages}]";
        }
    }
}
