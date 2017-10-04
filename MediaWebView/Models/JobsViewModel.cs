using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MediaAdmin.MediaEntity;

namespace MediaWebView.Models
{
    public class JobsListViewModel
    {
        public IEnumerable<Job> Jobs { get; set; }
    }
}