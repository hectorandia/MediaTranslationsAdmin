using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaAdmin.Abstract;

namespace MediaView.Controller
{
    public interface IEntityController
    {
         IEFEntityRepository Repository { get; set; }
    }
}
