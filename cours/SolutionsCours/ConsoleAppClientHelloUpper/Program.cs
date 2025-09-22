using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppClientHelloUpper.ServiceReference1;
namespace ConsoleAppClientHelloUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new ServiceHelloClient().SayHello("tyty"));
        }
    }
}
