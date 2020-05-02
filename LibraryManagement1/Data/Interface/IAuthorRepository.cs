using LibraryManagement1.Data.Model;
using System.Collections.Generic;

namespace LibraryManagement1.Data.Interface
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAllwithBooks();
        Author GetWithBooks(int id);
    }
}
