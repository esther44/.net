using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    public class DaoArticleSqlServer : IDaoArticle
    {
        public Article FindByRef(int id)
        {
            Article a = null;
            string connectionString = @"Data Source=MATBOOK-KAELAEN\SQLEXPRESS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "select * from articles where ref=" + id;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                a = new Article(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            }
            connection.Close();


            return a;
        }

        public void Insert(Article article)
        {
            string connectionString = @"Data Source=MATBOOK-KAELAEN\SQLEXPRESS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "insert into articles values (@ref,@marque,@prix)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add("ref", SqlDbType.Int).Value = article.Id;
            command.Parameters.Add("marque", SqlDbType.NVarChar).Value = article.Marque;
            command.Parameters.Add("prix", SqlDbType.Int).Value = article.Price;

            connection.Open();
            // execution de la requete
            command.ExecuteNonQuery();
            // Console.WriteLine(sql);

            connection.Close();
        }

        public List<Article> SelectAll()
        {
            List<Article> liste = new List<Article>();
            string connectionString = @"Data Source=MATBOOK-KAELAEN\SQLEXPRESS;Initial Catalog=ajc_tp;Integrated Security=True";
            string sql = "select * from articles";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Article a = new Article(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                liste.Add(a);
            }
            connection.Close();


            return liste;
        }
    }
}
