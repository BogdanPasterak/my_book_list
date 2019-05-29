using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public class BookService : IBookRepository
    {
        private List<Book> _books;

        public BookService()
        {
            if(_books == null)
            {
                _books = new List<Book>();
                for (int i = 0; i < 12; i++)
                    _books.Add(new Book());
            }
        }

        public Book GetBook(int bookId)
        {
            return _books.FirstOrDefault(p => p.Id == bookId); ;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }
    }
}
