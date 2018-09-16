using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesGorphs.Console.UI
{
    public class SortieAction : Action
    {
        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}
