using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest1
{
    public class EmpDAO
    {
        private static string connectionString = "User Id=scott;Password=tiger;Data Source=localhost:1521/XE";

        public List<Emp> GetAll()
        {
            var list = new List<Emp>();

            using (var connection = new OracleConnection(connectionString))
            {
                string sql = "SELECT empno, ename, job, mgr, hiredate, sal, comm, deptno FROM emp";
                using (var command = new OracleCommand(sql, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Emp
                            {
                                EmpNo = reader.GetInt32(0),
                                EName = reader.IsDBNull(1) ? null : reader.GetString(1),
                                Job = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Mgr = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3),
                                HireDate = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                                Sal = reader.IsDBNull(5) ? (decimal?)null : reader.GetDecimal(5),
                                Comm = reader.IsDBNull(6) ? (decimal?)null : reader.GetDecimal(6),
                                DeptNo = reader.IsDBNull(7) ? (int?)null : reader.GetInt32(7)
                            });
                        }
                    }
                }
            }

            return list;
        }

        public void Insert(Emp emp)
        {
            using (var connection = new OracleConnection(connectionString))
            {
                string sql = @"INSERT INTO emp (empno, ename, job, mgr, hiredate, sal, comm, deptno)
                    VALUES (:empno, :ename, :job, :mgr, :hiredate, :sal, :comm, :deptno)";

                using (var command = new OracleCommand(sql, connection))
                {
                    command.Parameters.Add(":empno", emp.EmpNo);
                    command.Parameters.Add(":ename", emp.EName);
                    command.Parameters.Add(":job", emp.Job);
                    command.Parameters.Add(":mgr", emp.Mgr.HasValue ? (object)emp.Mgr.Value : DBNull.Value);
                    command.Parameters.Add(":hiredate", emp.HireDate.HasValue ? (object)emp.HireDate.Value : DBNull.Value);
                    command.Parameters.Add(":sal", emp.Sal.HasValue ? (object)emp.Sal.Value : DBNull.Value);
                    command.Parameters.Add(":comm", emp.Comm.HasValue ? (object)emp.Comm.Value : DBNull.Value);
                    command.Parameters.Add(":deptno", emp.DeptNo.HasValue ? (object)emp.DeptNo.Value : DBNull.Value);

                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Insertion réussie !");
                }
            }
        }
    }
}
        