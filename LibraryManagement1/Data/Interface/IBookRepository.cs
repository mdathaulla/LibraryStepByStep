using LibraryManagement1.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement1.Data.Interface
{
    public interface IBookRepository
    {
       IEnumerable<Book> GetAllWithAuthor();
       IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate);
       IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate);
    }
}
