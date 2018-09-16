using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesGorphs.Console.UI
{
    public abstract class Action : IAction
    {
        /// <summary>
        /// Exécute une action
        /// </summary>
        public abstract void Execute();
    }
}
