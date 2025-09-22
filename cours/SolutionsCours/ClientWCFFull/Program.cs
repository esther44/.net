using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientWCFFull.NS1;
using ClientWCFFull.NS2;

namespace ClientWCFFull
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGetData();
            TestCoucou();
        }

        static void TestGetData()
        {
            Console.WriteLine(new Service1Client().GetData());
        }

        static void TestCoucou()
        {
            Console.WriteLine(new ServiceJackyClient().GetCoucou("titi"));
        }
    }
}
