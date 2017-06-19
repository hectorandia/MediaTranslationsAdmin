using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediaAdmin.MediaEntity;

namespace MediaWebView.Models
{
    public class CustomersListViewModel
    {
        public IEnumerable<Customers> Customers { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCity { get; set; }
    }
}