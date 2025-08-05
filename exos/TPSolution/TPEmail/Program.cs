using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
        }

        static void test()
        {
            File file = new File("tutu", 1.2);
            Email email = new Email(file, "dest", "exp", "message", "titre");

            Console.WriteLine(email.ToString());


        }
    }
}
