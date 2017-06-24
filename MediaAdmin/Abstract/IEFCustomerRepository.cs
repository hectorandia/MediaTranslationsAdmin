using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.MediaEntity;

namespace MediaAdmin.Abstract
{
    public interface IEFCustomerRepository
    {
        IEnumerable<Customer> Customers { get; }

        void SaveCustomer(Customer customer);

        Customer DeleteCustomer(int customerID);
    }
}
