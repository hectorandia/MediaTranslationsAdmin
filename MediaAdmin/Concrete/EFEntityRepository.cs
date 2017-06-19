using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;

namespace MediaAdmin.Concrete
{
    public class EFEntityRepository : IEFEntityRepository
    {
        private EFDbMediaTranslations context = new EFDbMediaTranslations();

        public IEnumerable<Customers> Customers
        {
            get
            {
                return context.Customers;
            }
        }

        public IEnumerable<Jobs> Jobs
        {
            get
            {
                return context.Jobs;
            }
        }

        public IEnumerable<Translators> Translators
        {
            get
            {
                return context.Translators;
            }
        }

        public void SaveCustomer(Customers customer)
        {
            if(customer.CustomerID == 0)
            {
                context.Customers.Add(customer);
            }
            else
            {
                Customers dbEntry = context.Customers.Find(customer.CustomerID);
                {
                    if(dbEntry != null)
                    {
                        dbEntry.Name = customer.Name;
                        dbEntry.City = customer.City;
                        dbEntry.Email = customer.Email;
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
