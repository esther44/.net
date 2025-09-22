using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace tpAdo1
{
    class Db
    {
        public static void Delete(int id, string connectionString)
        {
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "delete articles where ref=" + id;
            SqlCommand command = new SqlCommand(sql, connection1);
            command.ExecuteNonQuery();

            Console.WriteLine("delete  ok");
            connection1.Close();
        }

        public static void Insert(int refArticle, int prix, string marque, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO articles (@ref, @prix, @marque)";
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sql;

                    command.Parameters.Add("ref", SqlDbType.Int);
                    command.Parameters.Add("prix", SqlDbType.Int);
                    command.Parameters.Add("marque", SqlDbType.VarChar);

                    command.ExecuteNonQuery();
     

                Console.WriteLine("Insert OK");
            }
        }

        public static void Update(int refArticle, int prix, string marque, string connectionString)
        {
   

                string sql = "UPDATE articles SET marque = @marque, prix = @prix WHERE ref = @ref";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();

            Console.WriteLine("update ok");
            connection.Close();

       
            }

            public static string SelectAll(string connectionString)
            {
            string reponse = "REF\tPRIX\tMARQUE\n";

            SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                //traitement
                string sql = "select * from articles";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int refArticle = reader.GetInt32(0);      
                string marque = reader.GetString(1);       
                int prix = reader.GetInt32(2);            

                reponse += $"{refArticle}\t{marque}\t{prix}\n";
            }

            connection.Close();

                return reponse;
            }

        public static string SelectById(int id, string connectionString)
        {
            string reponse = "ID\tREF\tPRIX\tMARQUE\n";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //traitement
            string sql = "select * from articles where ref=" + id;
            SqlCommand command = new SqlCommand(sql, connection);



            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int refArticle = reader.GetInt32(0);
                string marque = reader.GetString(1);
                int prix = reader.GetInt32(2);

                reponse += $"{refArticle}\t{marque}\t{prix}\n";
            }

            connection.Close();

            return reponse;

        }

        public static decimal SelectAvgPrice(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "SELECT AVG(prix) FROM articles";
            SqlCommand command = new SqlCommand(sql, connection);

            object result = command.ExecuteScalar();

            connection.Close();

            if (result != DBNull.Value && result != null)
            {
                return Convert.ToDecimal(result);
            }
            else
            {
                return 0; // si aucun article n'existe
            }
        }
    }
}
