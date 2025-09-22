using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpDaoArticles
{
    public class DaoArticle
    {
        public Article SelectById(int id)
        {

            Article a = null;
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //traitement
            string sql = "select * from articles where ref=" + id;
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            // object reader2 = command.ExecuteScalar();

            if (reader.Read())
            {
                a = new Article(reader.GetInt32(0), reader.GetString(1),
                    reader.GetInt32(2));
            }

            connection.Close();

            return a;

        }

        public List<Article> SelectAll()
        {

            List<Article> liste = new List<Article>();
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //traitement
            string sql = "select * from articles";
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Article p = new Article(reader.GetInt32(0), reader.GetString(1),
                   reader.GetInt32(2));
                liste.Add(p);
            }

            connection.Close();

            return liste;

        }

        public void Update(Article a)
        {

            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "update articles set marque='" + a.Marque + "',prix=" + a.Prix + "  where ref=" + a.Ref;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            // execution de la requete
            command.ExecuteNonQuery();
            //int nb = command.ExecuteNonQuery();


            connection.Close();


        }

        public void Insert(Article a)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "insert into articles values (@ref,@marque,@prix)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add("ref", SqlDbType.Int).Value = a.Ref;
            command.Parameters.Add("marque", SqlDbType.NVarChar).Value = a.Marque;
            command.Parameters.Add("prix", SqlDbType.Int).Value = a.Prix;

            connection.Open();
            // execution de la requete
            command.ExecuteNonQuery();
            // Console.WriteLine(sql);

            connection.Close();

        }

        public void Delete(int id)
        {

            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "delete from articles where ref=" + id;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            // execution de la requete
            int nb = command.ExecuteNonQuery();


            connection.Close();



        }
    }
}
