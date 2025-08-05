using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTableauIntv1();
        }

        static void TestTableauIntv1()
        {
            int x;
            //  int[] tab = new int[3];
            int[] tab;
            const int taille = 3;
            tab = new int[taille];
            tab[0] = 10;
            tab[2] = 30;

            //Console.WriteLine(tab[0]);
            //Console.WriteLine(tab[1]);
            //Console.WriteLine(tab[2]);

            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i]);

        
        }

        static void TestTableauIntv2()
        {

            int[] tab = { 10, 0, 30 };
            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i]);

            tab[1] = 100;
            Console.WriteLine("-----------------------");
            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i]);
        }

        static void TestTableauForeach()
        {
            int[] tab1 = { 10, 0, 0, 0, 0, 30 };
            string[] tab2 = { "xx", null, null, null, "zz" };

            for (int i = 0; i < tab1.Length; i++)
                Console.Write(tab1[i] + "\t");
            Console.WriteLine("\n------------------------------");
            foreach (int e in tab1)
                Console.Write(e + "\t");

            Console.WriteLine("\n------------------------------");
            foreach (string e in tab2)
                if (e != null)
                    Console.Write(e.ToUpper() + "\t");
        }

        static void Affiche(int[] x)
        {
            foreach (int e in x)
                Console.Write(e + "\t");
            Console.WriteLine("\n------------------------------");

        }

        static void Affiche(string[] x)
        {
            foreach (string e in x)
                if (e != null)
                    Console.Write(e.ToUpper() + "\t");
            Console.WriteLine("\n------------------------------");

        }

        static void TestTableauForeachBis()
        {
            int[] tab1 = { 10, 0, 0, 0, 0, 30 };
            int[] tab1bis = { 10, 20, 30 };


            string[] tab2 = { "xx", null, null, null, "zz" };
            string[] tab2bis = { "aa", "bb", "cc" };

            Affiche(tab1);
            Affiche(tab1bis);

            Affiche(tab2);
            Affiche(tab2bis);




            //foreach(int e in tab1)
            //    Console.Write(e+"\t");
            //Console.WriteLine("\n------------------------------");

            //foreach (int e in tab1bis)
            //    Console.Write(e + "\t"); 
            //Console.WriteLine("\n------------------------------");

            //foreach (string e in tab2)
            //    if(e!=null)
            //    Console.Write(e.ToUpper() + "\t");
            //Console.WriteLine("\n------------------------------");

            //foreach (string e in tab2bis)
            //    if (e != null)
            //        Console.Write(e.ToUpper() + "\t");
            //Console.WriteLine("\n------------------------------");
        }

        static void TestDoublerTableau()
        {
            int[] tab1 = { 10, 20, 30, 40, 50 };
            Affiche(tab1);


            int[] tab2 = DoublerTableau(tab1);
            Affiche(tab2);
        }

        static int[] DoublerTableau(int[] x)
        {
            int[] y = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
                y[i] = x[i] * 2;
            return y;
        }

        static void TestDoublerTableauv2()
        {
            int[] tab1 = { 10, 20, 30, 40, 50 };

            Affiche(tab1);

            DoublerTableauv2(tab1);
            Affiche(tab1);

        }

        static void DoublerTableauv2(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
                x[i] *= 2;

        }

        static void TestAfficheNombre()
        {
            AfficherNombres(10);
            AfficherNombres(10, 20);
            AfficherNombres(10, 20, 30);

        }

        static void AfficherNombres(params int[] nombres)
        {
            Console.WriteLine("Liste des nombres :");
            foreach (int n in nombres)
            {
                Console.WriteLine(n);
            }
        }

        //static void AfficherNombres(int a, int b)
        //{
        //    Console.WriteLine(a+"    "+b);
        //}


        //static void AfficherNombres(int a)
        //{
        //    Console.WriteLine(a);
        //}

        static void testSort()
        {
            int[] tab = { 10, 3, 2 };
            Affiche(tab);
            Array.Sort(tab);
            Affiche(tab);
        }

    }
}
