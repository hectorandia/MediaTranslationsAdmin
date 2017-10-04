using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;
using MediaWebView.Models;
using System.Globalization;

namespace MediaWebView.Controllers
{
    public class CustomerController : Controller
    {
        private IEFCustomerRepository repository;
        private int PageSize = 8;
        List<string> CountryList = new List<string>();
        List<string> LanguageList = new List<string>();
        List<string> CustomertypeList = new List<string>();


        public CustomerController(IEFCustomerRepository customerRepository)
        {
            this.repository = customerRepository;
            LoadCultureInfo();
            CustomertypeList.Add("Company");
            CustomertypeList.Add("Private");
        }

        //GET: All Customers
        public ViewResult CustomersList()
        {
            CustomersListViewModel model = new CustomersListViewModel
            {
                Customers = repository.Customers.OrderBy(c => c.CustomerID)
            };
            return View(model);
        }

        
        public ViewResult CustomerView(int customerID)
        {
            //Customer customer = repository.Customers.FirstOrDefault(c => c.CustomerID == customerID);
            //return View(customer);
            CustomerInfoView model = new CustomerInfoView
            {
                Customer = repository.Customers.FirstOrDefault(c => c.CustomerID == customerID)
            };
            return View(model);
        }

        //public ViewResult Create()
        //{
        //    List<string> CountryList = new List<string>();
        //    CultureInfo[] CInfoList = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
        //    foreach (CultureInfo CInfo in CInfoList)
        //    {
        //        RegionInfo R = new RegionInfo(CInfo.LCID);
        //        if (!(CountryList.Contains(R.EnglishName)))
        //        {
        //            CountryList.Add(R.EnglishName);
        //        }
        //    }
        //    CountryList.Sort();
        //    ViewBag.CountryList = CountryList;
        //    return View("Edit", new Customer());
        //}

        
        public ActionResult CreateCustomer()
        {
            ViewBag.CustomertypeList = CustomertypeList;
            return View(new Customer());
        }

        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.Added = DateTime.Now;
                //customer.Birthdate = DateTime.Now;
                repository.SaveCustomer(customer);
                TempData["message"] = string.Format("{0} has been saved", customer.Name);
                return RedirectToAction("CustomersList");
            }
            else
            {
                //there is something wrong with the data values
                ViewBag.HasErrors = true;
                return View(customer);
            }
        }

        public void LoadCultureInfo()
        {
            CultureInfo[] CInfoList = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo CInfo in CInfoList)
            {
                RegionInfo R = new RegionInfo(CInfo.LCID);
                if (!(CountryList.Contains(R.DisplayName)))
                {
                    CountryList.Add(R.DisplayName);
                    LanguageList.Add(CInfo.DisplayName);
                }
            }
            LanguageList.Sort();
            CountryList.Sort();
            ViewBag.LanguageList = LanguageList;
            ViewBag.CountryList = CountryList;
        }
        
    }
}