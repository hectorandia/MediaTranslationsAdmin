using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;
using System.Globalization;

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
            List<string> CountryList = new List<string>();
            CultureInfo[] CInfoList = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo CInfo in CInfoList)
            {
                RegionInfo R = new RegionInfo(CInfo.LCID);
                if (!(CountryList.Contains(R.EnglishName)))
                {
                    CountryList.Add(R.EnglishName);
                }
            }
            CountryList.Sort();
            ViewBag.CountryList = CountryList;
            Customer customer = repository.Customers.FirstOrDefault(c => c.CustomerID == customerID);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            List<string> CountryList = new List<string>();
            CultureInfo[] CInfoList = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo CInfo in CInfoList)
            {
                RegionInfo R = new RegionInfo(CInfo.LCID);
                if (!(CountryList.Contains(R.EnglishName)))
                {
                    CountryList.Add(R.EnglishName);
                }
            }
            CountryList.Sort();
            ViewBag.CountryList = CountryList;

            if (ModelState.IsValid)
            {
                repository.SaveCustomer(customer);
                TempData["message"] = string.Format("{0} has been saved", customer.Name);
                return RedirectToAction("Index");
            }
            else
            {
                //there is something wrong with the data values
                ViewBag.HasErrors = true;
                return View(customer);
            }
           
        }

        
        public ViewResult Create()
        {
            List<string> CountryList = new List<string>();
            CultureInfo[] CInfoList = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo CInfo in CInfoList)
            {
                RegionInfo R = new RegionInfo(CInfo.LCID);
                if (!(CountryList.Contains(R.EnglishName)))
                {
                    CountryList.Add(R.EnglishName);
                }
            }
            CountryList.Sort();
            ViewBag.CountryList = CountryList;
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