using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAffiche();
        }

        //user
        static void TestAffiche()
        {
            Affiche();
            Affiche();
        }
        //dev
        static void Affiche()
        {

            Console.WriteLine("je suis Affiche");
        }

        static void TestPrint()
        {
            string nom = "jean ";
            Print("toto");
            Print("titi");
            Print(nom);

        }

        static void Print(string str)
        {
            Console.WriteLine("BONJOUR  " + str);
        }
        static void TestAddition()
        {
            Addition(10.0, 20.0);
            Addition(15.5, 35.6);

        }

        static void Addition(double a, double b)
        {
            double c = a + b;
            Console.WriteLine(c);
        }

        static void TestAdd()
        {
            //1
            double res = Add(10, 20);
            Console.WriteLine("res " + res);

            //2
            Add(10, 20);

            //3
            Console.WriteLine("res " + Add(10, 20));


        }


        static double Add(double a, double b)
        {
            double c = a + b;
            return c;
        }

        static void TestSwap()
        {
            int nb1 = 10;
            int nb2 = 20;
            Console.WriteLine(nb1 + "      " + nb2);
            Swap(ref nb1, ref nb2);
            Console.WriteLine(nb1 + "      " + nb2);
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;

        }

        static void TestCalculate()
        {
            int x = 10;
            int y = 15;

            int s;
            int d;



            Calculate(x, y, out s, out d);
            Console.WriteLine(x + "   " + y + "   " + s + "   " + d);
        }

        static void Calculate(int a, int b, out int somme, out int difference)
        {
            somme = a + b;
            difference = a - b;
        }

        static void TestTryParse()
        {
            Console.Write("Entrez un nombre entier : ");
            string input = Console.ReadLine();

            int result;
            bool success = Int32.TryParse(input, out result);

            if (success)
            {
                Console.WriteLine($"Vous avez entré le nombre : {result}");
            }
            else
            {
                Console.WriteLine("Ce n'est pas un entier valide.");
            }
        }

        static void TestImprimer()
        {
            Imprimer("toto");
            Imprimer(2);
            Imprimer(2, 1);
            Imprimer(2, "");
            Imprimer("", 2);
        }

        ////8
        //static int Imprimer(int x, int y)

        //{
        //    Console.WriteLine("coucou valeur:" + x + "   " + y);
        //    return x + y;

        //}

        //7
        static void Imprimer(string y, int x)

        {
            Console.WriteLine("coucou valeur:" + x + "   " + y);

        }


        //6
        static void Imprimer(int x, string y)

        {
            Console.WriteLine("coucou valeur:" + x + "   " + y);

        }

        //5
        static void Imprimer(int x, int y)

        {
            Console.WriteLine("coucou valeur:" + x + "   " + y);

        }


        //4
        static void Imprimer(int x)

        {
            Console.WriteLine("coucou valeur:" + x);

        }

        ////3
        //static void Imprimer(string nom)

        //{
        //    Console.WriteLine("coucou NOM:" + nom);

        //}

        //2
        static void Imprimer(string nom)

        {
            Console.WriteLine("coucou NOM:" + nom);

        }
        //1
        static void Imprimer()
        {
            Console.WriteLine("coucou");
            
}
}
}
