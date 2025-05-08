using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZI_Zad26
{
    public class BookList
    {
        private List<Book> books;
        public int Count { get { return books.Count; }}
        public BookList()
        {
            this.books = new List<Book>();
        }//end1
        public Book Get(int index)
        {
            if (index<0||index>books.Count-1)
            {
                throw new IndexOutOfRangeException();
            }
            return this.books[index];
        }//end2
        public void Add(Book book)
        {
            if (books.Any(x => x.CompareTo(book) == 0))
            {
                throw new ArgumentException("Книгата вече съществува в списъка!");
            }

            books.Add(book);
            books.Sort();
        }//end3
    }
}
