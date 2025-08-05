using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHeritageV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Test5();
        }

        static void Test11()
        {
            Voiture v1 = new Voiture("renault", 10);
            Bateau v2 = new Bateau("aaa", 10, 2);
            TestIs(v1);
            TestIs(v2);

            TestAs(v1);
            TestAs(v2);
        }

        static void TestAs(Vehicule v)
        {
            Voiture x = v as Voiture;
            if (x != null)
                Console.WriteLine("cest une voiture " + v);
        }

        static void TestIs(Vehicule v)
        {
            if (v is Voiture)
            {
                Voiture x = (Voiture)v;
                x.gpsOnOff();
                Console.WriteLine(x);
            }
        }

        static void Test10()
        {
            Voiture v1 = new Voiture("renault", 10);
            Vehicule v2 = v1;
            Velo v3 = (Velo)v2;
        }

        static void Test9() {
           Vehicule v1 = new Voiture("peugeot", 20);
            Voiture v2 = new Voiture("renault", 10);
            Velo v3 = new Velo("xx", 10);
            Bateau v4 = new Bateau("aaa", 10, 2);


            TestToString(v1);
            TestToString(v2);
            TestToString(v3);
            TestToString(v4);
            TestToString(10);
            TestToString("toto");
        }

        static void TestToString(object v)
        {
            Console.WriteLine(v);

        }

        static void Test8()
        {
            Vehicule v1 = new Voiture("peugeot", 20);
            Voiture v2 = new Voiture("renault", 10);
            Velo v3 = new Velo("xx", 10);
            Bateau v4 = new Bateau("aaa", 10, 2);

            TestAvancer(v1);
            TestAvancer(v2);
            TestAvancer(v3);
            TestAvancer(v4);
        }

        static void TestAvancer(Vehicule v)
        {
            Console.WriteLine(v.Avancer());
        }


        static void Test7()
        {
            object[] tab = {
                new Voiture("aa",10),
                new Voiture("Nissan", 2500.0),
                new Velo("VTT", 150.0),
                new Bateau("Titanic", 1.0, 1500),
                10,
            "toto"};
            foreach (object o in tab)
                Console.WriteLine(o.ToString());
        }

        static void Test6()
        {

            Vehicule[] tab = {
                new Voiture("aa",10),
                new Voiture("Nissan", 2500.0),
                new Velo("VTT", 150.0),
                new Bateau("Titanic", 1.0, 1500),
           };
            foreach (Vehicule o in tab)
                Console.WriteLine(o.Avancer());
        }

        static void Test5()
        {
            Voiture v1 = new Voiture("peugeot", 20);
            Voiture v2 = new Voiture("renault", 10);
            Velo v3 = new Velo("xx", 10);
            Bateau v4 = new Bateau("aaa", 10, 2);

            Vehicule[] tab = new Vehicule[4];
            tab[0] = v1;
            tab[1] = v2;// voiture vers vehicule
            tab[2] = v3;
            tab[3] = v4;


            foreach (Vehicule v in tab)
                Console.WriteLine(v.Avancer());

        }

        static void Test4()
        {
            Vehicule v1 = new Velo("bmx", 100);
            Console.WriteLine(v1.Avancer());
        }


        static void Test3()
        {

            Voiture v1 = new Voiture("renault", 10);
            v1.gpsOnOff();

            Vehicule v2 = v1;

        }

        static void Test2()
        {


            B monB1 = new B();
            A monB2 = monB1;

            B monB3 = (B)monB2;

        }

        static void Test1()
        {
            A monA = new A();
            monA.M1();

            B monB1 = new B();
            A monB2 = new B();
            monB1.M2();
            monB2.M1();

            C monC1 = new C();
            A monC2 = new C();
        }
    }
}
