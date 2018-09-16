using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesGorphs.Console.UI
{
    /// <summary>
    /// Interface représentant le contrat d'une action
    /// </summary>
    public interface IAction
    {
        /// <summary>
        /// Exécute une action
        /// </summary>
        void Execute();
    }
}
