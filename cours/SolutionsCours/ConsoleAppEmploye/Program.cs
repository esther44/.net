using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppEmploye.NSEmploye;
namespace ConsoleAppEmploye
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe emp = new SrvEmployeClient().GetEmploye();
            Console.WriteLine(emp.Nom + "  " + emp.Prenom);
        }
    }
}
