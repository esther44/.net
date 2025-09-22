using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetAdo1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSelectByIdWithScalar();
        }

        static void TestSelectByIdWithScalar()
        {
            Console.WriteLine(Db.SelectByIdWithScalar(15));
        }

        static void TestSelectById()
        {
            Console.WriteLine(Db.SelectById(15));
        }

        static void TestSelectAll()
        {
            Console.WriteLine(Db.SelectAll());
        }


        static void TestUpdate()
        {
            Db.Update(15, "TOTO", "TITI", 25);
        }

        static void TestDelete()
        {
            Db.Delete(12);

        }

        static void TestInsertV2()
        {
            Db.Insertv2(18, "toto", "titi", 22);
        }

        static void TestInsert()
        {
            Db.Insert(15, "toto", "titi", 25);
        }


        static void TestConnexion()
        {
            string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_formation;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //traitement
            Console.WriteLine("test connexion ok");
            connection.Close();

        }
    }
}
