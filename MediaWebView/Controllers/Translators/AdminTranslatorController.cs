using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;

namespace MediaWebView.Controllers.Translators
{
    public class AdminTranslatorController : Controller
    {
        private IEFTranslatorRepository repository;

        public AdminTranslatorController(IEFTranslatorRepository repo)
        {
            repository = repo;
        }
        // GET: AdminTranslator
        public ActionResult Index()
        {
            return View(repository.Translators);
        }


        public ViewResult Edit(int translatorID)
        {
            Translator translator = repository.Translators.FirstOrDefault(t => t.TranslatorID == translatorID);
            return View(translator);
        }
    }
}