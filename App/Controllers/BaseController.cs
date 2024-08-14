using DegreeExamen.App.Commands;
using System.Threading.Tasks;

namespace DegreeExamen.App.Controllers
{
    internal abstract class BaseController
    {
        protected BaseCommand Command;

        public abstract Task Handle();

       
    }

}
