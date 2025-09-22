using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpclientService.Calcule;
namespace tpclientService
{
    class Program
    {
        static void Main(string[] args)
        {

            Test1();

        }

        static void Test1()
        {
            Service1Client service = new Service1Client();
            Console.WriteLine(service.Add(1,2));
        }
    }
}
