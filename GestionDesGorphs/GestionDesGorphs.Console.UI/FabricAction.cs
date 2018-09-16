using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesGorphs.Console.UI
{
    public static class FabricAction
    {
        /// <summary>
        /// Permet d'obtenir une action d'exécution, après choix dans le menu de l'utilisateur
        /// </summary>
        /// <param name="choix">Choix de l'utilisateur (chaîne)</param>
        /// <returns></returns>
        public static IAction CreateOne(string choix)
        {
            ChoixMenu reelChoix = (ChoixMenu)Enum.Parse(typeof(ChoixMenu), choix);

            return CreateOne(reelChoix);
        }

        /// <summary>
        /// Permet d'obtenir une action d'exécution, après choix dans le menu de l'utilisateur
        /// </summary>
        /// <param name="choix">Choix de l'utilisateur</param>
        /// <returns></returns>
        public static IAction CreateOne(ChoixMenu choix)
        {
            IAction action = null;

            if(choix == ChoixMenu.AjouterAnimal)
            {
                action = new ListerAnimauxAction();
            }
            else if(choix == ChoixMenu.ListerAnimaux)
            {
                action = new AjouterAnimalAction();
            }

            return action;
        }
    }
}
