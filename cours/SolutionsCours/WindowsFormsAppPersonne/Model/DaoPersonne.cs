using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPersonne.Model
{
    class DaoPersonne
    {
        public List<Personne> SelectAll()
        {

            List<Personne> liste = new List<Personne>();
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //traitement
            string sql = "select * from personnes";
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Personne p = new Personne(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                   reader.GetInt32(3));
                liste.Add(p);
            }

            connection.Close();

            return liste;

        }



        public void Insert(Personne p)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            string sql = "insert into personnes values (@id,@nom,@prenom,@age)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add("id", SqlDbType.Int).Value = p.Id;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = p.Nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = p.Prenom;
            command.Parameters.Add("age", SqlDbType.Int).Value = p.Age;

            connection.Open();
            // execution de la requete
            command.ExecuteNonQuery();
            // Console.WriteLine(sql);

            connection.Close();

        }



    }
}
