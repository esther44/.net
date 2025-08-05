using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            TpTraitementTexte();
        }

        static void Affiche<T>(T[] x)
        {
            foreach (T e in x)
                Console.Write(e + "\t");
            Console.WriteLine("\n------------------------------");

        }

        static void TpTraitementTexte()
        {
            Console.WriteLine("votre texte");
            string text = Console.ReadLine();

            string[] result = Traitement.TraitementText(text);
            Affiche(result);
        }



    }
}
