using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.MediaEntity;

namespace MediaAdmin.Abstract
{
    public interface IEFEntityRepository
    {
        IEnumerable<Customers> Customers { get; }
        IEnumerable<Jobs> Jobs { get; }
        IEnumerable<Translators> Translators { get; }

        void SaveCustomer(Customers customer);
    }
}
