using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;

namespace MediaWebView.Controllers
{
    public class TranslatorController : Controller
    {
        private IEFEntityRepository repository;

        public TranslatorController(IEFEntityRepository translatorRepository)
        {
            this.repository = translatorRepository;
        }

        // GET: Translator
        public ViewResult List()
        {
            return View(repository.Translators);
        }
    }
}