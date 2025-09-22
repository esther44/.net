using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpDaoArticleComponent.DAO;

namespace tpDaoArticleComponent.DAL
{
    class Db: System.ComponentModel.Component
    {
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;

        public List<Article> SelectAll()
        {

            List<Article> liste = new List<Article>();

            sqlConnection1.Open();

            //traitement

            SqlDataReader reader = sqlCommand1.ExecuteReader();

            while (reader.Read())
            {
                Article a = new Article(reader.GetInt32(0), reader.GetString(1),
                   reader.GetInt32(2));
                liste.Add(a);
            }

            sqlConnection1.Close();

            return liste;

        }

        public Db()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT        articles.*\r\nFROM            articles";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);

        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }
    }
}
