using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest1
{
    class Program
    {
        static EmpDAO empDao = new EmpDAO();

        static void Main(string[] args)
        {
            TestInsert();
        }

        static void TestSelectAllEmp()
        {
            var emps = empDao.GetAll();
            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }
        }

        static void TestInsert()
        {
            TestSelectAllEmp();

            empDao.Insert(new Emp
            {
                EmpNo = 13,
                EName = "Guillaume",
                Job = "MECANO",
                Mgr = 7566,
                HireDate = new DateTime(2012, 12, 12),
                Sal = 12000,
                Comm = 12,
                DeptNo = 10
            });

            TestSelectAllEmp();
        }
    }
}

