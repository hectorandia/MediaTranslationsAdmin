using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;

namespace MediaAdmin.Concrete
{
    public class EFECustomerRepository : IEFCustomerRepository
    {
        private EFDbMediaTranslations context = new EFDbMediaTranslations();

        public IEnumerable<Customer> Customers
        {
            get
            {
                return context.Customers;
            }
        }

        public void SaveCustomer(Customer customer)
        {
            if(customer.CustomerID == 0)
            {
                context.Customers.Add(customer);
            }
            else
            {
                Customer dbEntry = context.Customers.Find(customer.CustomerID);
                {
                    if(dbEntry != null)
                    {
                        dbEntry.Name = customer.Name;
                        dbEntry.LastName = customer.LastName;
                        dbEntry.Address = customer.Address;
                        dbEntry.City = customer.City;
                        dbEntry.ZIP = customer.ZIP;
                        dbEntry.Country = customer.Country;
                        dbEntry.Email = customer.Email;
                    }
                }
            }
            context.SaveChanges();
        }

        public Customer DeleteCustomer(int customerID)
        {
            Customer dbEntry = context.Customers.Find(customerID);
            if(dbEntry != null)
            {
                context.Customers.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
