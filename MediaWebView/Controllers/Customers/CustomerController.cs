using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;
using MediaWebView.Models;

namespace MediaWebView.Controllers
{
    public class CustomerController : Controller
    {
        private IEFCustomerRepository repository;
        private int PageSize = 8;       

        public CustomerController(IEFCustomerRepository customerRepository)
        {
            this.repository = customerRepository;
        }

        // GET: Customer
    //    public ViewResult List(string city,int page = 1)
    //    {
    //        CustomersListViewModel model = new CustomersListViewModel
    //        {
    //            Customers = repository.Customers.Where(c => city == null || c.City == city)
    //            .OrderBy(c => c.CustomerID).Skip((page - 1) * PageSize).Take(PageSize),
    //            PagingInfo = new PagingInfo
    //            {
    //                CurrentPage = page,
    //                ItemsPerPage = PageSize,
    //                TotalItems = city == null ? repository.Customers.Count() : repository.Customers.Where(c => c.City == city).Count()
    //            },
    //            CurrentCity = city
    //        };

    //        return View(model);
    //    }

        //GET: All Customers
        public ViewResult List()
        {
            CustomersListViewModel model = new CustomersListViewModel
            {
                Customers = repository.Customers.OrderBy(c => c.CustomerID)
                //PagingInfo = new PagingInfo
                //{
                //    CurrentPage = page,
                //    ItemsPerPage = PageSize,
                //    TotalItems = repository.Customers.Count()
                //}

            };
            return View(model);
        }
    }
}