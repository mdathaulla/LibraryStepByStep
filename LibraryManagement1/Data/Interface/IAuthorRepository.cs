using LibraryManagement1.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement1.Data.Interface
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAllwithBooks();
        Author GetWithBooks(int id);
    }
}
