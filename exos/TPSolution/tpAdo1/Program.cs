using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace tpAdo1
{
    class Program
    {

        private static string connectionString = @"Data Source=DESKTOP-AD02GFS;Initial Catalog=ajc_tp;Integrated Security=True";

        static void Main(string[] args)
        {
            TestSelectAvgPrice();
        }

        static void TestSelectAvgPrice()
        {
            Console.WriteLine(Db.SelectAvgPrice(connectionString));
        }

        static void TestSelectByIdWithScalar()
        {
            Console.WriteLine(Db.SelectById(3, connectionString));
        }

        static void TestSelectAll()
        {
            Console.WriteLine(Db.SelectAll(connectionString));
        }

        static void TestDelete()
        {
            Db.Delete(12, connectionString);
        }



        static void TestUpdate()
        {
            Db.Update(1, 123, "adidas", connectionString);
        }


        static void TestInsert()
        {
            Db.Insert(5, 222, "nike", connectionString);
        }
    }
}
