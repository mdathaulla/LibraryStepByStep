using LibraryManagement1.Data.Interface;
using LibraryManagement1.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement1.Data.Repository
{
    public class CustomerRepository:Repository<Customer>,ICustomerRepository
    {
        public CustomerRepository(LibraryDbContext context) :base(context)
        {

        }
    }
}
