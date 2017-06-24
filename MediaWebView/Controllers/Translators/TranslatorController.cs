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
        private IEFTranslatorRepository repository;

        public TranslatorController(IEFTranslatorRepository translatorRepository)
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