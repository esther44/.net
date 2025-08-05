using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCollectionV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test4();
        }


        static void Test5()
        {

            Employee[] tab = {new Employee("xx","dd",10),
                              new Employee("zz","yy",5),
                               new Employee("yy","bb",15)};

            foreach (Employee p in tab)
                Console.WriteLine(p);

            Array.Sort(tab, new EmployeSortPrenom());

            foreach (Employee p in tab)
                Console.WriteLine(p);


        }

        static void Test4()
        {

            Employee[] tab = {new Employee("xx","dd",10),
                              new Employee("zz","yy",5),
                               new Employee("yy","bb",15)};

            foreach (Employee p in tab)
                Console.WriteLine(p);

            Array.Sort(tab, new EmployeSortNom());

            foreach (Employee p in tab)
                Console.WriteLine(p);
        }

        static void Test3()
        {
            Personne[] tab = {new Personne("cc","dd",10),
                              new Personne("xx","yy",5),
                               new Personne("aa","bb",15)};

            foreach (Personne e in tab)
                Console.Write(e + "\t\t");
            Console.WriteLine("\n**********************************");

            Array.Sort(tab);

            foreach (Personne e in tab)
                Console.Write(e + "\t\t");
        }


        static void Test2()
        {
            string[] tab1 = { "zzz", "aaa", "hhh" };


            foreach (string e in tab1)
                Console.Write(e + "\t");
            Console.WriteLine("\n**********************************");

            Array.Sort(tab1);
            foreach (string e in tab1)
                Console.Write(e + "\t");


        }
        static void Test1()
        {

            int[] tab1 = { 10, 5, 2, 1 };
            foreach (int e in tab1) Console.Write(e + "\t");
            Console.WriteLine();
            Array.Sort(tab1);
            foreach (int e in tab1) Console.Write(e + "\t");

        }
    }
}
