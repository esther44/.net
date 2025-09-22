using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetDaoPersonneComponent.DAL
{
    public class Db: System.ComponentModel.Component
    {
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;

        public List<Personne> SelectAll()
        {

            List<Personne> liste = new List<Personne>();

            sqlConnection1.Open();

            //traitement

            SqlDataReader reader = sqlCommand1.ExecuteReader();

            while (reader.Read())
            {
                Personne p = new Personne(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                   reader.GetInt32(3));
                liste.Add(p);
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=Tru" +
    "e";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT        personnes.*\r\nFROM            personnes";
            this.sqlCommand1.Connection = this.sqlConnection1;

        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }
    }
}
