﻿using System;
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
        private IEFEntityRepository repository;

        public JobController(IEFEntityRepository jobRepository)
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