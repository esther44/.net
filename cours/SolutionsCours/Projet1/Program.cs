using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStringBuilder();
        }

        static void M1()
        {
            Console.WriteLine("je suis M1");
            int a = 0;
            Console.WriteLine(a);

            string str = "10";
            int x = Int32.Parse(str);
            x++;
            Console.WriteLine(x);

            double d = 10.3;

        }

        static void M2()
        {
            string str1 = "Bonjour";
            string str2 ="toto";
            string str3 = "a bienntôt";

            string str = str1 + "\t\t" + str2 + str3;
        }

        static void M3()
        {
            string path1 = @"C:\tmp\test.txt";
            string path2 = "C:\\tmp\\test.txt";
            string path3 = "C:\tmp\test.txt";

            Console.WriteLine(path1);
            Console.WriteLine(path2);
            Console.WriteLine(path3);
        }

        static void M4()
        {
            Console.WriteLine("merci de saisir votre nom");
            string saisie = Console.ReadLine();
            string reponse = "bienvenue " + saisie;
            Console.WriteLine(reponse);
        }

        static void M5()
        {
            string str = "10";
            int a = Convert.ToInt32(str);
            int b = Int32.Parse(str);
            a++;
            b++;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void M6()
        {
            string str = "TotO";
            string str1 = str.ToUpper();
            string str2 = str.ToLower();
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }

        static void M7()
        {
            string nom = "dupond";
            string prenom = "toto";

            //string str = nom +"  "+ prenom;
            //Console.WriteLine(str);

            // Console.WriteLine("NOM: "+nom+"  PRENOM: "+prenom);
            Console.WriteLine("NOM:{0}  PRENOM:{1}", nom, prenom);
        }

        static void M8()
        {
            Console.Write("test1\n");
            Console.Write("test2");
        }

        static void M9()
        {
            string str = "bonjour";
            str += " toto"; // str=str+" toto"
            str += " a bientot";

            Console.WriteLine(str);
        }

        static void M10()
        {
            int a = 10;
            a *= 2; // a=a*2
            Console.WriteLine(a);
        }

        static void M11()
        {
            Console.WriteLine("age?");
            int age = Convert.ToInt32(Console.ReadLine());
        }

        static void M12()
        {
            string str = "10a";
            //int age = Convert.ToInt32(str);
            // int age = Int32.Parse(str);
            //   int age = Int32.TryParse()
            Console.WriteLine(str);
        }

        static void M13()
        {
            int a = 100000000;
            // short b = Convert.ToInt16(a);
            short c = (short)a;
            long d = a;

        }

        static void M14()
        {
            const int a = 1000;
            Console.WriteLine(a);
            // a = 10;

        }

        static void M15()
        {
            int a = 7;
            int b;
            b = a++;
            Console.WriteLine("postfix   a:" + a + "     b:" + b);//8  7
            b = ++a;
            Console.WriteLine("prefix a:" + a + "     b:" + b);//9  9
     

        }

        static void TestIfv1()
        {
            int a = 15;
            int b = 15;
            if (a == b)
                Console.WriteLine("a et b egaux");
            Console.WriteLine("a bientot");
        }

        static void TestIfv2()
        {
            int a = 10;
            int b = 15;
            if (a == b)
                Console.WriteLine("a et b egaux");
            else
                Console.WriteLine("a et b differents");
            Console.WriteLine("a bientot");

        }

        static void TestIfv3()
        {
            int a = 18;
            int b = 15;
            if (a < b)
                Console.WriteLine("a < b ");

            else if (a > b)
                Console.WriteLine("a > b ");

            else
                Console.WriteLine("a = b ");

        }

        static void TestIfv4()
        {
            int a = 10;
            int b = 15;

            if (a == b)
            {
                Console.WriteLine("a et b egaux");
            }
            else
            {
                int x = 10;
                Console.WriteLine("a et b differents");
                Console.WriteLine("a bientot " + x);
            }


        }

        static void TestIfv5()
        {

            Console.WriteLine("saisir le nombre a ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("saisir le nombre b ");
            int b = Convert.ToInt32(Console.ReadLine());

            string resultat;


            if (!(a == b)) //((a == b) == false) 
                resultat = "a et b differents";
            else
                resultat = "a et b egaux";

            Console.WriteLine(resultat);
        }

        static void TestIfv6()
        {
            Console.WriteLine("saisir un nombre entre 1 et 10");
            int nombre = Convert.ToInt32(Console.ReadLine());

            if ((nombre > 1) && nombre < 10)
                Console.WriteLine("ok");
            else Console.WriteLine("ko");

        }

        //static void TestTernairev1()
        //{
        //    string resultat;

        //    Console.WriteLine("saisir le nombre a ");
        //    int a = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("saisir le nombre b ");
        //    int b = Convert.ToInt32(Console.ReadLine());

        //    //if (a == b)
        //    //    resultat="a et b egaux";

        //    //else
        //    //  resultat ="a et b differents";


        //    resultat = (a == b) ? "a et b egaux" : "a et b differents";


        //    Console.WriteLine(resultat);
        //}​


        static void TestSwitchv1()
        {
            Console.WriteLine("saisir le nombre pour avoir le jour ");
            int a = Convert.ToInt32(Console.ReadLine());

            //1 lundi 2 mardi
            string resultat;

            switch (a)
            {

                case 1:
                    resultat = "lundi";
                    resultat += "  debut de semaine";
                    break;
                case 2:
                    resultat = "mardi";
                    break;
                case 3:
                    resultat = "mercredi";
                    break;
                case 4:
                    resultat = "jeudi";
                    break;
                case 5:
                    resultat = "vendredi";
                    break;

                case 6:

                case 7:
                    resultat = "we";
                    break;


                default:
                    resultat = "NA";
                    break;
            }

            Console.WriteLine(resultat);
        }

        static void TestForv1()
        {
            int i;
            for (i = 0; i < 10; i++)
                Console.WriteLine("coucou " + i);
            Console.WriteLine("valeur finale " + i);

        }


        static void TestForv2()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("coucou " + i);
                Console.WriteLine("a bientot " + i);

            }

            Console.WriteLine("fin  " + i);


        }

        static void TestForv3()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) break;
                Console.WriteLine("coucou " + i);
            }
            Console.WriteLine(" a bientot");


        }

        static void TestForv4()
        {
            int max = 10;
            for (int i = 0; i < max; i++)
            {
                if (i == 5) continue;
                Console.WriteLine("coucou " + i);
            }


        }

        static void TPBoucleV1()
        {
            Console.WriteLine("Hauteur");
            int hauteur = int.Parse(Console.ReadLine());
            Console.WriteLine("Largeur");
            int largeur = int.Parse(Console.ReadLine());
            Console.WriteLine("Chaine de caractère");
            string chaine = Console.ReadLine();

            for (int i = 0; i < hauteur; i++) // Lignes
            {
                for (int j = 0; j < largeur; j++) // Colonnes
                {
                    Console.Write(chaine + "\t");
                }
                Console.WriteLine(); // Retour à la ligne après chaque ligne
            }
        }

        static void TestStringBuilder()
        {
            string str = "a";
            str += "b";
            str += "c";

            StringBuilder sb = new StringBuilder();
            sb.Append("a");
            sb.Append("b");
            sb.Append("c");

            string res = sb.ToString();
            Console.WriteLine(res);

        }

        static void TestWhile()
        {
            int i = 0;
            const int MAX = 10;


            while (i < MAX)
            {
                i++;
                Console.Write(".");
            }
            Console.WriteLine("\nFin!");
        }

        static void TestDoWhile()
        {

            int i = 0;
            const int MAX = 10;
            do
            {
                i++;
                Console.Write(".");
            }
            while (i < MAX);
        }
        static void TestDoWhilev3()
        {

            int i = 0;

            bool isValid = false;
            do
            {
                i++;
                if (i == 5) isValid = true;
                Console.Write(".");
            }
            while (!isValid);

            Console.WriteLine("\nFin!");
        }

        static void TestRandom()
        {
            Random r = new Random();
            int nb = r.Next(10);

            Console.WriteLine("RANDOM  " + nb);
        }
    }
}
