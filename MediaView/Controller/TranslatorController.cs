using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.Abstract;
using MediaAdmin.Abstract;

namespace MediaView.Controller
{
    public class TranslatorController : IEntityController
    {
        private IEFEntityRepository repository;

        public TranslatorController(IEFEntityRepository translatorRepository)
        {
            repository = translatorRepository;
        }

        public IEFEntityRepository Repository
        {
            get
            {
                return repository;
            }
            set
            {
                repository = value;
            }
        }
    }
}
