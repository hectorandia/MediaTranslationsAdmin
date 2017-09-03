using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediaAdmin.MediaEntity;

namespace MediaWebView.Models
{
    public class CustomersListViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
    }

    public class CustomerInfoView
    {
        public Customer Customer { get; set; }
    }
}