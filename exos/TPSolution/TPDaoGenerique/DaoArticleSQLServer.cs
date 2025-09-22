using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPDaoGenerique
{
    class DaoArticleSQLServer : IDaoArticle
    {
        public void Create(Article a)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "insert into articles values (@ref,@marque,@prix)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add("ref", SqlDbType.Int).Value = a.RefArticle ;
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

        public List<Article> FindAll()
        {
            List<Article> liste = new List<Article>();
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "select * from articles";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Article a = new Article(reader.GetInt32(0), reader.GetString(1),
                   reader.GetInt32(2));
                liste.Add(a);
            }
            connection.Close();


            return liste;
        }

        public Article FindById(int id)
        {
            Article a = null;
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "select * from articles where ref=" + id;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                a = new Article(reader.GetInt32(0), reader.GetString(1),
                   reader.GetInt32(2));
            }
            connection.Close();


            return a;
        }

        public List<Article> FindByMarqueLike(string marque)
        {
            List<Article> liste = new List<Article>();
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "select * from articles where marque like @marque ";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@marque", SqlDbType.NVarChar).Value = "%" + marque + "%";

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Article a = new Article(reader.GetInt32(0), reader.GetString(1), 
                   reader.GetInt32(2));
                liste.Add(a);
            }
            connection.Close();


            return liste;
        }

        public List<Article> FindByPrixMinMax(int prixMin, int prixMax)
        {
            List<Article> liste = new List<Article>();
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "SELECT * FROM articles WHERE prix BETWEEN @prixMin AND @prixMax";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@prixMin", SqlDbType.Int).Value = prixMin;
            command.Parameters.Add("@prixMax", SqlDbType.Int).Value = prixMax;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Article a = new Article(reader.GetInt32(0), reader.GetString(1), 
                   reader.GetInt32(2));
                liste.Add(a);
            }
            connection.Close();


            return liste;
        }

        public void Update(Article a)
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "UPDATE articles SET marque = @marque, prix = @prix WHERE ref = @ref";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@marque", SqlDbType.NVarChar).Value = a.Marque;
            command.Parameters.Add("@prix", SqlDbType.Int).Value = a.Prix;
            command.Parameters.Add("@ref", SqlDbType.Int).Value = a.RefArticle;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();


        }
    }
}
