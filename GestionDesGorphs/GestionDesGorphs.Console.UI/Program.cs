using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesGorphs.Console.UI
{
    /// <summary>
    /// Choix de l'action possible dans le menu
    /// </summary>
    public enum ChoixMenu
    {
        ListerAnimaux = 1,
        AjouterAnimal = 2,
        NourrirUnAnimal = 2,
        NettoyerCageAnimal = 3,
        VendreAnimal = 10,
        VoirBilan = 100,
        Sortie = -10
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bienvenue dans l'application de gestion des Sertapils");

            bool pasSorti = true;
            while (pasSorti)
            {
                System.Console.WriteLine("Choisissez ce que vous voulez faire  :");

                AfficherMenu();

                pasSorti = false;
            }

            System.Console.ReadLine();
        }

        static void AfficherMenu()
        {
            string[] listChoix = Enum.GetNames(typeof(ChoixMenu));

            foreach (var item in listChoix)
            {
                ChoixMenu choix = (ChoixMenu) Enum.Parse(typeof(ChoixMenu), item);
                System.Console.WriteLine($"{choix} : {item}");
            }

            string choixFinal = System.Console.ReadLine();

            try
            {
                FabricAction.CreateOne(choixFinal).Execute();
            }
            catch (SqlException ex)
            {
                System.Console.WriteLine("Une erreur est survenue");
            }
        }
    }
}
