using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesGorphs.Console.UI
{
    public class ListerAnimauxAction : Action
    {
        public override void Execute()
        {
            System.Console.WriteLine("Liste des sertapils");

            using (SqlConnection connection = new SqlConnection(@"DESKTOP-LES1U0B\SQLEXPRESS"))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Sertapil ORDER BY Name";
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        System.Console.WriteLine(string.Format("-> {0} / taille : {1} ", reader["Name"], reader["Taille"]));
                    }

                    reader.Close();
                }
            }
        }
    }
}
