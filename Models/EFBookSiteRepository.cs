using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BookSite2._0.Models
{
    public class EFBookSiteRepository : IBookSiteRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookSiteRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;

        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}
