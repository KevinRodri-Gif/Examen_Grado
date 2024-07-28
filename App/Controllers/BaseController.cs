using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeExamen.App.Controllers
{
    internal abstract class BaseController
    {
        public abstract Task Handle();
    }
}
