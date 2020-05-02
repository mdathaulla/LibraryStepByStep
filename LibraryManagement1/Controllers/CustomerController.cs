using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement1.Data.Interface;
using LibraryManagement1.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement1.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository _customerRepository;
        private IBookRepository _bookRepository;

        public CustomerController(ICustomerRepository customerRepository,IBookRepository bookRepository)
        {
            _customerRepository = customerRepository;
            _bookRepository = bookRepository;
        }
        [Route("Customer")]
        public IActionResult List()
        {
            var customerVM = new List<CustomerViewModel>();
            var customers = _customerRepository.GetAll();
            if (customers.Count() ==0)
            {
                return View("Empty");
            }
            foreach (var customer in customers)
            {
                customerVM.Add(new CustomerViewModel
                {
                    Customer = customer,
                    BookCount = _bookRepository.Count(x => x.BorrowerId == customer.CustomerId)
                });
            }
            return View(customerVM);

        }
    }
}