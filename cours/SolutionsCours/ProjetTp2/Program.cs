using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTp2
{
    class Program
    {
        static void Main(string[] args)
        {
            TPCalcule();
        }

        static void TpPuissancev2()
        {
            Console.WriteLine("Chosissez un nombre");
            int nombre = int.Parse(Console.ReadLine());
            Console.WriteLine("Choisissez une puissance");
            int puissance = int.Parse(Console.ReadLine());

            int resultat = PuissanceV2(nombre, puissance);

            Console.WriteLine("Résultat:" + resultat);
        }

        static int PuissanceV2(int nombre, int puissance)
        {

            int resultat = 1;

            for (int i = 0; i < puissance; i++)
            {
                resultat *= nombre;
            }

            return resultat;
        }

        static void TpCalculArticle()
        {
            Console.WriteLine("Chosissez une marque");
            string marque = Console.ReadLine();
            Console.WriteLine("Choisissez un prix HT");
            double prixHT = double.Parse(Console.ReadLine());
            Console.WriteLine("Choisissez une TVA");
            double TVA = double.Parse(Console.ReadLine());
            Console.WriteLine("Choisissez une reduc");
            int reduc = int.Parse(Console.ReadLine());

            double prixTTC;
            double prixTTCAvecReduc;

            CalculatePrixTTCArticle(prixHT, TVA, reduc, out prixTTC, out prixTTCAvecReduc);
            AfficherResultat(marque, prixHT, prixTTC, prixTTCAvecReduc, TVA, reduc);
        }

        static void CalculatePrixTTCArticle(double prixHT, double TVA, int reduc,  out double prixTTC, out double prixTTCAvecReduc)
        {
            double montantTVA = prixHT * TVA / 100;
            prixTTC = prixHT + montantTVA;
            prixTTCAvecReduc = prixTTC * (1 - (double)reduc / 100);
        }

        static void AfficherResultat(string marque, double prixHT, double prixTTC, double prixTTCAvecReduc, double TVA, int reduc)
        {
            Console.Write($"marque :" + marque + "\n" +
                " prixHT: " + prixHT + "\n" +
                " prixTTC : " + prixTTC + "\n" +
                " prix après reduc : " + prixTTCAvecReduc + "\n" +
                " TVA : " + TVA + "% \n" +
                " reduc : " + reduc + "%");
        }

        static void TPCalcule()
        {
            Console.WriteLine("Nombre 1");
            double nb1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nombre 2");
            double nb2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Opérateur");
            string operateur = Console.ReadLine();

            double result = Calcule(nb1, nb2, operateur);
            Console.WriteLine(result);
      
        }

        static double Calcule(double nb1, double nb2, string operateur)
        {

            switch (operateur)
            {
                case "+":
                    return Addition(nb1, nb2);
                case "-":
                    return Soustraction(nb1, nb2);
                case "/":
                    return Division(nb1, nb2);
                case "*":
                    return Multiplication(nb1, nb2);
                default:
                    Console.WriteLine("Opérateur non reconnu");
                    return Double.NaN;
            }
        }

        static double Addition(double nb1, double nb2)
        {
            return nb1 + nb2;
        }

        static double Soustraction(double nb1, double nb2)
        {
            return nb1 - nb2;
        }

        static double Division(double nb1, double nb2)
        {
            return nb1 / nb2;
        }

        static double Multiplication(double nb1, double nb2)
        {
            return nb1 * nb2;
        }
    }
}
