using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;

namespace MediaWebView.Controllers
{
    public class AdminCustomerController : Controller
    {
        private IEFCustomerRepository repository;

        public AdminCustomerController(IEFCustomerRepository repo)
        {
            repository = repo;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View(repository.Customers);
        }

        public ViewResult Edit(int customerID)
        {
            Customer customer = repository.Customers.FirstOrDefault(c => c.CustomerID == customerID);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if(ModelState.IsValid)
            {
                repository.SaveCustomer(customer);
                TempData["message"] = string.Format("{0} has been saved", customer.Name);
                return RedirectToAction("Index");
            }
            else
            {
                //there is something wrong with the data values
                return View(customer);
            }
           
        }

        public ViewResult Create()
        {
            return View("Edit", new Customer());
        }

        [HttpPost]
        public ActionResult Delete(int customerID)
        {
            Customer deleteCustomer = repository.DeleteCustomer(customerID);
            if(deleteCustomer != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deleteCustomer.Name);
            }
            return RedirectToAction("Index");
        }
    }
}