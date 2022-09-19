using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class BookLibrary
    {
        private List<Book> _books = new List<Book>();
        
        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Remove(Book book)
        {
            _books.Remove(book);
        }

        public IEnumerable<Book> Search(string query)
        {
            return _books.Where(b => b.Title.Contains(query, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
