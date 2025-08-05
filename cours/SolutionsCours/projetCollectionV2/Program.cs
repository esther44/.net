using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCollectionV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
        }

        static void Test6()
        {

            Dictionary<string, string> dico = new Dictionary<string, string>();
            dico.Add("aa", "06254784");
            dico.Add("bb", "123456");
            dico.Add("cc", "012542544");

            Console.WriteLine("choisir depuis la liste:");

            ICollection<string> cle = dico.Keys;
            foreach (string e in cle)
                Console.Write(e + "\t");

            string saisie = Console.ReadLine().ToLower();

            Console.WriteLine(dico[saisie]);


        }


        static void Test5()
        {

            Dictionary<string, string> dico = new Dictionary<string, string>();
            dico.Add("aa", "06254784");
            dico.Add("bb", "06254784");
            dico.Add("cc", "012542544");
            dico.Add("dd", null);

            string result = dico["cc"];
            Console.WriteLine(result);
        }


        static void Test4()
        {
            ICollection x = new List<int>();
            ((List<int>)x).Add(10);
            ICollection y = new Queue<int>();

            Console.WriteLine(x.Count);
            Console.WriteLine(y.Count);
        }​

        static void Test3()
        {
            Queue<Employe> file = new Queue<Employe>();
            file.Enqueue(new Employe("aa", "aa", 10));
            file.Enqueue(new Employe("bb", "bb", 10));
            file.Enqueue(new Employe("cc", "cc", 10));

            foreach (Employe e in file)
                Console.WriteLine(e);

            Console.WriteLine("-------------------------------");
            Employe x = file.Dequeue();
            Console.WriteLine("sortie de la personne  " + x);
            Console.WriteLine("-------------------------------");
            foreach (Employe e in file)
                Console.WriteLine(e);
            Console.WriteLine("-------------------------------");
            Employe y = file.Peek();
            Console.WriteLine(y);
            Console.WriteLine("-------------------------------");
            foreach (Employe e in file)
                Console.WriteLine(e);
        }

        static void Test1()
        {
            //ArrayList
            //List<object> al = new List<object>();
            //ArrayList l1 = new ArrayList();



            List<int> liste1 = new List<int>();
            liste1.Add(10);
            liste1.Add(20);
            liste1.Add(30);
            liste1.Add(40);

            foreach (int e in liste1)
                Console.Write(e + "\t");

        }
    }
}
