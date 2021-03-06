using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSite2._0.Models
{
    public interface IBookSiteRepository
    {
        IQueryable<Book> Books { get; }
        void SaveBook(Book b);
        void CreateBook(Book b);

        void DeleteBook(Book b);
    }
}
