using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesGorphs.Console.UI
{
    public class AjouterAnimalAction : Action
    {
        public override void Execute()
        {
            Sertapil animal = new Sertapil();
            System.Console.WriteLine("Ajout d'un nouveau sertapil");

            System.Console.WriteLine("Choisissez le nom :");
            animal.Nom = System.Console.ReadLine();

            System.Console.WriteLine("Choisissez la taille :");
            animal.Taille = decimal.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Choisissez le prix de naissance :");
            animal.PrixNaissance = decimal.Parse(System.Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(@"Server=DESKTOP-LES1U0B\SQLEXPRESS;Database=BaseSuiviSertapils;Trusted_Connection=True;"))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    string sql = animal.ToString();

                    command.CommandText = sql;

                    command.ExecuteNonQuery();

                    System.Console.WriteLine("Le sertapil a bien été ajouté");
                }
            }
        }
    }
}
