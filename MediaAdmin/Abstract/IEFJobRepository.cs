using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.MediaEntity;

namespace MediaAdmin.Abstract
{
    public interface IEFJobRepository
    {
        IEnumerable<Job> Jobs { get; }

        void SaveJob(Job job);
    }
}
