using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPersonneV5
{
    class Program
    {
        static void Main(string[] args)
        {
            Test3();
        }


        static void Test1()
        {
            Groupe g1 = new Groupe("AJC formation", 15);
            Console.WriteLine(g1);
            Personne p1 = new Personne(1, "dupond", "aa", 10);
            Personne p2 = new Personne(3, "dupond", "bb", 15);
            g1.Ajouter(p1);
            g1.Ajouter(p2);
            g1.Ajouter(new Personne(5, "dupond", "cc", 20));
            g1.Ajouter(new Personne(7, "dupond", "dd", 25));
            Console.WriteLine(g1);
        }

            static void Test2()
            {
                Groupe g1 = new Groupe("AJC formation", 15);
                Personne p1 = new Personne(1, "dupond", "aa", 10);
                Personne p2 = new Personne(3, "dupond", "bb", 15);
                Personne p3 = new Personne(4, "dupond", "bb", 15);
                g1.Ajouter(p1);
                g1.Ajouter(p2);
                g1.Ajouter(new Personne(5, "dupond", "cc", 20));
                g1.Ajouter(new Personne(7, "dupond", "dd", 25));
                Console.WriteLine(g1);
                Console.WriteLine("--------------");
                g1.Supprimer(p1);
                g1.Supprimer(p2);
                g1.Supprimer(p3);
                Console.WriteLine(g1);

            }

        static void Test3()
        {
            Groupe g1 = new Groupe("AJC");
            Personne p1 = new Personne(1, "dupond", "aa", 10);
            Personne p2 = new Personne(3, "dupond", "bb", 15);

            g1.Ajouter(p1);
            g1.Ajouter(p2);

            g1.Ajouter(new Personne(5, "dupond", "cc", 20));
            g1.Ajouter(new Personne(7, "dupond", "dd", 25));

            Console.WriteLine(g1.GetCount());

        }
    }
}
