using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;

namespace MediaWebView.Controllers
{
    public class JobController : Controller
    {
        private IEFJobRepository repository;

        public JobController(IEFJobRepository jobRepository)
        {
            this.repository = jobRepository;
        }
        // GET: Job
        public ViewResult List()
        {
            return View(repository.Jobs);
        }
    }
}