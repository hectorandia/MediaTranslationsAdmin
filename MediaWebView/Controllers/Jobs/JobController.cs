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
            JobsListViewModel model = new JobsListViewModel
            {
                Jobs = repository.Jobs.OrderBy(j => j.JobID)
            };
            return View(model);
        }

        public ActionResult CreateJob()
        {          
            return View(new Job());
        }

        [HttpPost]
        public ActionResult CreateJob(Job job)
        {
            if (ModelState.IsValid)
            {
                job.Added = DateTime.Now;
                repository.SaveJob(job);
                TempData["message"] = string.Format("{0} has been saved", job.JobID);
                return RedirectToAction("JobList");
            }
            else
            {
                //there is something wrong with the data values
                ViewBag.HasErrors = true;
                return View(job);
            }
        }


    }
}