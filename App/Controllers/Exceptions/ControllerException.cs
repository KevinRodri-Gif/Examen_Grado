using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeExamen.App.Controllers.Exceptions
{
    internal sealed class ControllerException: Exception
    {
        public ControllerException(string message) : base(message) { }
    }
}
