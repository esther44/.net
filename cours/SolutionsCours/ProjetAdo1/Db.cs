using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetAdo1
{
    class Db
    {
        public static void Delete(int id)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString);
            connection1.Open();
            //traitement
            string sql = "delete personnes where id =" + id;
            SqlCommand command = new SqlCommand(sql, connection1);
            command.ExecuteNonQuery();

            Console.WriteLine("delete  ok");
            connection1.Close();
        }


        public static void Insert(int id, string nom, string prenom, int age)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //traitement
            string sql = "insert into personnes values(" + id + ",'" + nom + "','" + prenom + "'," + age + ")";
            SqlCommand command = new SqlCommand(sql, connection);
            //Console.WriteLine(sql);
            command.ExecuteNonQuery();

            Console.WriteLine("insert ok");
            connection.Close();

        }

        public static void Insertv2(int id, string nom, string prenom, int age)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            string sql = "insert into personnes values (@id,@nom,@prenom,@age)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = prenom;
            command.Parameters.Add("age", SqlDbType.Int).Value = age;

            connection.Open();

            command.ExecuteNonQuery();
            Console.WriteLine("insert ok");

            connection.Close();
        }

        public static void Update(int id, string nom, string prenom, int age)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //traitement
            string sql = "update personnes set nom = '" + nom + "',prenom='" + prenom + "',age=" + age + " where id=" + id;
            SqlCommand command = new SqlCommand(sql, connection);
            // Console.WriteLine(sql);
            command.ExecuteNonQuery();

            Console.WriteLine("update ok");
            connection.Close();

        }

        public static string SelectAll()
        {
            string reponse = "ID\tNOM\tPRENOM\tAGE\n";

            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //traitement
            string sql = "select * from personnes";
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                reponse += reader.GetInt32(0) + "\t" + reader.GetValue(1)
                   + "\t" + reader.GetString(2) + "\t" + reader.GetInt32(3) + "\n";
            }

            connection.Close();

            return reponse;
        }

        public static string SelectByIdWithScalar(int id)
        {
            string reponse = "ID\tNOM\tPRENOM\tAGE\n";

            string connectionString = @"Data Sourc=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //traitement
            string sql = "select * from personnes where id=" + id;
            SqlCommand command = new SqlCommand(sql, connection);


            // object reader2 = command.ExecuteScalar();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                reponse += reader.GetInt32(0) + "\t" + reader.GetValue(1)
                   + "\t" + reader.GetString(2) + "\t" + reader.GetInt32(3) + "\n";
            }

            connection.Close();

            return reponse;

        }

        public static string SelectById(int id)
        {
            string reponse = "ID\tNOM\tPRENOM\tAGE\n";

            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //traitement
            string sql = "select * from personnes where id=" + id;
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                reponse += reader.GetInt32(0) + "\t" + reader.GetValue(1)
                   + "\t" + reader.GetString(2) + "\t" + reader.GetInt32(3) + "\n";
            }

            connection.Close();

            return reponse;

        }


    }
}
