using DegreeExamen.App.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
