using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.Abstract;

namespace MediaView.Controller
{
    public class CustomerController : IEntityController
    {
        private IEFEntityRepository repository;

        public CustomerController(IEFEntityRepository customerRepository)
        {
            repository = customerRepository;
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
