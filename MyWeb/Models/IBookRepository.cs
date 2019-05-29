using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int bookId);
    }
}
