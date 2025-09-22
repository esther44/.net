using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDaoPersonne
{
    class DaoPersonne
    {// crud dao 2 methodes select 3 methodes pour ecriture

        public Personne SelectById(int id)
        {

            Personne p = null;
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //traitement
            string sql = "select * from personnes where id=" + id;
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            // object reader2 = command.ExecuteScalar();

            if (reader.Read())
            {
                p = new Personne(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetInt32(3));
            }

            connection.Close();

            return p;

        }

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

        public void Update(Personne p)
        {

            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            string sql = "update personnes set nom='" + p.Nom + "',prenom='" + p.Prenom + "',age=" + p.Age + "  where id=" + p.Id;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            // execution de la requete
            command.ExecuteNonQuery();
            //int nb = command.ExecuteNonQuery();


            connection.Close();


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

        public void Delete(int id)
        {

            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            string sql = "delete from personnes where id=" + id;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            // execution de la requete
            int nb = command.ExecuteNonQuery();


            connection.Close();



        }

    }
}
