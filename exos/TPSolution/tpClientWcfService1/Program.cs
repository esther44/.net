using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculs;

namespace tpClientWcfService1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            TestAdd(a, b);

            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            TestSous(c, d);

            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            TestMult(e, f);

            double g = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            TestDiv(g, h);
        }

        static void TestAdd(int a, int b)
        {
            Service1Client calculs = new Service1Client();

            Console.WriteLine(calculs.Add(a, b));
        }

        static void TestSous(int a, int b)
        {
            Service1Client calculs = new Service1Client();

            Console.WriteLine(calculs.Sous(a, b));
        }

        static void TestMult(double a, double b)
        {
            Service1Client calculs = new Service1Client();

            Console.WriteLine(calculs.Mult(a, b));
        }

        static void TestDiv(double a, double b)
        {
            Service1Client calculs = new Service1Client();

            Console.WriteLine(calculs.Div(a, b));
        }
    }
}
