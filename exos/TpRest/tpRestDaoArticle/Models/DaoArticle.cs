using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace tpRestDaoArticle.Models
{
    public class DaoArticle
    {
        private static string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";

        public void Insert(Article a)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO articles (ref, marque, prix) VALUES (@ref, @marque, @prix)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ref", a.Reference);
                cmd.Parameters.AddWithValue("@marque", a.Marque);
                cmd.Parameters.AddWithValue("@prix", a.Prix);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Article> SelectAll()
        {
            var list = new List<Article>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT ref, marque, prix FROM articles";
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Article
                    {
                        Reference = reader.GetInt32(0),
                        Marque = reader.GetString(1),
                        Prix = reader.GetInt32(2)
                    });
                }
            }
            return list;
        }

        public Article SelectByRef(int reference)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT ref, marque, prix FROM articles WHERE ref=@ref";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ref", reference);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Article
                    {
                        Reference = reader.GetInt32(0),
                        Marque = reader.GetString(1),
                        Prix = reader.GetInt32(2)
                    };
                }
                return null;
            }

        }

        public void Update(Article a)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE articles SET marque=@marque, prix=@prix WHERE ref=@ref";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ref", a.Reference);
                cmd.Parameters.AddWithValue("@marque", a.Marque);
                cmd.Parameters.AddWithValue("@prix", a.Prix);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int reference)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM articles WHERE ref=@ref";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@ref", reference);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}