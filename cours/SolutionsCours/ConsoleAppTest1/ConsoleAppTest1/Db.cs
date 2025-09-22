using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest1
{
    class Db
    {
        private static string connectionString = "User Id=scott;Password=tiger;Data Source=localhost:1521/XE";
        private static OracleConnection connection = new OracleConnection(connectionString);


        public static string SelectAllEmp()
        {
            string response = "EMPNO\tENAME\tJOB\tMGR\tHIREDATE\tSAL\tCOM\tDEPTNO\n";

            string sql = "select * from emp";
            OracleCommand command = new OracleCommand(sql, connection);
            connection.Open();

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                response += reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t"+ reader.GetValue(2) + "\t" + reader.GetValue(3) + "\t" + reader.GetValue(4) + "\t" + reader.GetValue(5) + "\t" + reader.GetValue(6) + "\t" + reader.GetValue(7)+"\n";
            }

            connection.Close();

            return response;
        }

        public static void Insert(int empno, string ename, string job, int? mgr, DateTime hiredate, decimal sal, decimal? comm, int deptno)
        {
            
            connection.Open();

            string sql = @"INSERT INTO emp (empno, ename, job, mgr, hiredate, sal, comm, deptno)
                       VALUES (:empno, :ename, :job, :mgr, :hiredate, :sal, :comm, :deptno)";


            OracleCommand command = new OracleCommand(sql, connection);

            command.Parameters.Add(":empno", empno);
            command.Parameters.Add(":ename", ename);
            command.Parameters.Add(":job", job);
            command.Parameters.Add(":mgr", mgr.HasValue ? (object)mgr.Value : DBNull.Value);
            command.Parameters.Add(":hiredate", hiredate);
            command.Parameters.Add(":sal", sal);
            command.Parameters.Add(":comm", comm.HasValue ? (object)comm.Value : DBNull.Value);
            command.Parameters.Add(":deptno", deptno);

            command.ExecuteNonQuery();
            Console.WriteLine("insert OK");

            connection.Close();



        }
    }
}
