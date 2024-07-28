using DegreeExamen.App.Database;
using System.Threading.Tasks;

namespace DegreeExamen.App.Commands
{
    internal abstract class BaseCommand
    {
        protected readonly DatabaseManager Database;

        protected BaseCommand()
        {
            Database = DatabaseManager.Instance();
        }

        public abstract Task Handle();
    }
}
