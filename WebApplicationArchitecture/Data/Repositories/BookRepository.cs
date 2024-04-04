using Data.Context;
using Domain.Entities;
using Domain.Repositories.Interfaces;

namespace Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;
        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.OrderByDescending(b => b.InsertDate).ToList();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
