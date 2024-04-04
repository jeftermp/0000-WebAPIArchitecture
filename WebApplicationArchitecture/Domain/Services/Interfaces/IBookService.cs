using Domain.Entities;

namespace Domain.Services.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetById(int bookId);
    }
}
