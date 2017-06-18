using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;

namespace MediaWebView.Controllers
{
    public class CustomerController : Controller
    {
        private IEFEntityRepository repository;
       

        public CustomerController(IEFEntityRepository customerRepository)
        {
            this.repository = customerRepository;
        }
        // GET: Customer
        public ViewResult List()
        {
            return View(repository.Customers);
        }
    }
}