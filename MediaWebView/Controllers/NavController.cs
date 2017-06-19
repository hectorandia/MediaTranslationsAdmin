using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaAdmin.Abstract;


namespace MediaWebView.Controllers
{
    public class NavController : Controller
    {
        private IEFEntityRepository repository;

        public NavController(IEFEntityRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu(string city = null)
        {

            ViewBag.SelectedCity = city;
            //Son ordenado por la cantidad de coinsidencias mayor a menor
            IEnumerable<string> citys = repository.Customers.Select(x => x.City).Distinct().OrderBy(x => x);
            return PartialView(citys);
        }
    }
}