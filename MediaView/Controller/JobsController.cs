using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.Abstract;

namespace MediaView.Controller
{
    public class JobsController : IEntityController
    {
        private IEFEntityRepository repository;

        public JobsController(IEFEntityRepository jobRepository)
        {
            repository = jobRepository;
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
