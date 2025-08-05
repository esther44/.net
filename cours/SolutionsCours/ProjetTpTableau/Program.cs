using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTpTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            tpTraitementTexte();
        }

        static void Affiche<T>(T[] x)
        {
            foreach (T e in x)
                Console.Write(e + "\t");
            Console.WriteLine("\n------------------------------");

        }

        static void TestTPTableauV1()
        {
            Console.WriteLine("Taille du tableau :");
            int taille = int.Parse(Console.ReadLine());
            string[] tab = new string[taille];

            for (int i = 0; i < taille; i++)
            {
                Console.WriteLine("Indice " + i + " :");
                tab[i] = Console.ReadLine();
            }

            Console.WriteLine("Contenu du tableau :");
            foreach (var element in tab)
            {
                Console.WriteLine(element);
            }
        }

        static void TestTableauStringv1()

        {
            string[] tab1 = new string[4];
            //  string[] tab2 = { "xx","yy","zz"};
            tab1[0] = "aaa";
            tab1[1] = "bbb";
            tab1[2] = "ccc";
            // tab1[3] = "ddd";

            for (int i = 0; i < tab1.Length; i++)

                if (tab1[i] != null)
                    Console.Write(tab1[i].ToUpper() + "\t");

        }

        static void tpOccurrence()
        {
            int[] tab = { 10, 2, 30, 10, 1, 2, 5, 1 };

            foreach (int i in tab)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("Choisissez un entier de votre choix :");
            int response = int.Parse(Console.ReadLine());

            int result = occurence(tab, response);

            Console.WriteLine("resultat"+ result);
        }

        static int occurence(int[] tab, int response)
        {
            int occurence = 0;
            foreach(int o in tab)
            {
                if (o == response)
                {
                    occurence += 1;
                }
            }
            return occurence;
        }

        static void TpReverse()
        {
            int[] tab1 = { 10, 20, 30, 40, 50 };
            string[] tab2 = { "a", "b", "c", "d" };

            int[] tab3 = Reverse(tab1);
            string[] tab4 = Reverse(tab2);

            foreach(int i in tab3)
            {
                Console.WriteLine(i);
            }

            foreach (string s in tab4)
            {
                Console.WriteLine(s);
            }
        }

        static int[] Reverse(int[] tab)
        {
            int[] reverseTab = new int[tab.Length]; 

            for (int i = 0; i < tab.Length ; i++)
            {
                reverseTab[i] = tab[tab.Length -1 -i];
            }

            return reverseTab;
        }

        static string[] Reverse(string[] tab)
        {
            string[] reverseTab = new string[tab.Length];

            for (int i = 0; i < tab.Length; i++)
            {
                reverseTab[i] = tab[tab.Length -1 -i];
            }

            return reverseTab;
        }

        static void TPReverseV2()
        {
            int[] tab1 = { 10, 20, 30, 40, 50 };
            string[] tab2 = { "a", "b", "c"};

            Affiche(tab1);
            ReverseV2(tab1);
            Affiche(tab1);

            Affiche(tab2);
            ReverseV2(tab2);
            Affiche(tab2);

        }


        static void ReverseV2<T>(T[] tab)
        {
            int n = tab.Length;
            for (int i = 0; i < n / 2; i++)
            {
                T temp = tab[i];
                tab[i] = tab[n - 1 - i];
                tab[n - 1 - i] = temp;
            }
        }

        static void tpTraitementTexte()
        {
            Console.WriteLine("votre texte");
            string text = Console.ReadLine();

            string[] result = traitementText(text);
            Affiche(result);
        }

        static string[] traitementText(String str)
        {
            string[] strTransform = str.ToUpper().Split(' ');
            return Reverse(strTransform);
        }
    }
}
