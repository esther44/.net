using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest1
{
    public class Emp
    {
        public int EmpNo { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public int? Mgr { get; set; }
        public DateTime? HireDate { get; set; }
        public decimal? Sal { get; set; }
        public decimal? Comm { get; set; }
        public int? DeptNo { get; set; }

        public override string ToString()
        {
            return $"{EmpNo}\t{EName}\t{Job}\t{Mgr}\t{HireDate?.ToString("dd/MM/yy")}\t{Sal}\t{Comm}\t{DeptNo}";
        }
    }
}
