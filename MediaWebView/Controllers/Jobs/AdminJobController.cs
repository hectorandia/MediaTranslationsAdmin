using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;

namespace MediaWebView.Controllers.Jobs
{
    public class AdminJobController : Controller
    {
        private IEFJobRepository repository;

        public AdminJobController(IEFJobRepository repo)
        {
            repository = repo;
        }
        // GET: AdminJob
        public ActionResult Index()
        {
            return View(repository.Jobs);
        }

        public ViewResult Edit(int JobID)
        {
            Job job = repository.Jobs.FirstOrDefault(j => j.JobID == JobID);
            return View(job);
        }
    }
}