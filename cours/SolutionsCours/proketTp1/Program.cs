using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TPRandomV2();
        }

        static void TpInfos()
        {
            Console.WriteLine("Quel est votre nom ?");
            string Name = Console.ReadLine();
            Console.WriteLine("Quel est votre prénom ?");
            string First = Console.ReadLine();
            Console.WriteLine("Quel est votre age ?");
            string Age = Console.ReadLine();
            string result = Name + "\t" + First + "\n" + Age;
            Console.WriteLine("Hello " + result);
        }

        static void TPInfosPlus()
        {
            Console.WriteLine("Votre nom");
            string name = Console.ReadLine();

            Console.WriteLine("Votre prénom");
            string firstname = Console.ReadLine();

            Console.WriteLine("Votre année de naissance");
            int birthdate = int.Parse(Console.ReadLine());

            Console.WriteLine("Votre taille en mètres");
            double taille = double.Parse(Console.ReadLine());

            Console.WriteLine("Votre poids en kg");
            double poids = double.Parse(Console.ReadLine());

            string nameUpper = name.ToUpper();
            string firstnameLower = firstname.ToLower();
            int currentYear = 2025;
            int age = currentYear - birthdate;

            string resultat = string.Format(
                "NOM : {0}  PRENOM : {1}\nAGE: {2} ans\nTAILLE: {3} metre  POIDS {4} kg",
                nameUpper,
                firstnameLower,
                age,
                taille,
                poids
            );

            Console.WriteLine(resultat);
        }

        static void tpMax()
        {
            Console.WriteLine("Valeur 1");
            int valeur1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valeur 2");
            int valeur2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valeur 3");
            int valeur3 = int.Parse(Console.ReadLine());

            string result;

            if (valeur1 == valeur2 && valeur2 == valeur3)
            {
                result = $"Les trois valeurs sont identiques : {valeur1}";
            }
            else
            {
                int max = valeur1;
                if (valeur2 > max)
                    max = valeur2;
                if (valeur3 > max)
                    max = valeur2;
    

                result = $"Le maximum des trois valeurs ({valeur1}, {valeur2}, {valeur3}) est : {max}";
            }
        
            Console.WriteLine(result);
        }

        static void TPAge()
        {
            Console.WriteLine("Votre nom");
            string nom = Console.ReadLine();
            Console.WriteLine("Votre age");
            int age = int.Parse(Console.ReadLine());

            string categorieAge;

            if (age > 0 && age <= 120)
            {
                if (age < 18)
                    categorieAge = "mineur";
                else if (age < 50)
                    categorieAge = "majeur";
                else
                    categorieAge = "senior";
            }
            else
            {
                categorieAge = "erreur";
            }

            Console.Write($"{nom}, { age}ans, status {categorieAge}");
        }

        static void TPTernaire()
        {
            Console.WriteLine("Chiffre 1");
            short chiffre1 = short.Parse(Console.ReadLine());
            Console.WriteLine("Chiffre 2");
            short chiffre2 = short.Parse(Console.ReadLine());
            Console.WriteLine("Chiffre 3");
            short chiffre3 = short.Parse(Console.ReadLine());

            int max = (chiffre1 > chiffre2) ? (chiffre3 > chiffre1 ? chiffre3 : chiffre1) : (chiffre3 > chiffre2 ? chiffre3 : chiffre2);

            Console.WriteLine(max);
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

        static void TPBoucleV3()
        {
            const int iterations = 100000;

            // --- Version 2 : string += ---
            Stopwatch sw2 = Stopwatch.StartNew();

            string str = "";
            for (int i = 0; i < iterations; i++)
            {
                str += "a";
            }

            sw2.Stop();
            Console.WriteLine("Résultat V2 : " + str.Substring(0, 10) + "...");
            Console.WriteLine("Temps V2 (string +=) : " + sw2.ElapsedMilliseconds + " ms");

            // --- Version 3 : StringBuilder ---
            Stopwatch sw3 = Stopwatch.StartNew();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("a");
            }

            string res = sb.ToString();
            sw3.Stop();

            Console.WriteLine("Résultat V3 : " + res.Substring(0, 10) + "...");
            Console.WriteLine("Temps V3 (StringBuilder) : " + sw3.ElapsedMilliseconds + " ms");
        }

        static void tpPuissance()
        {
            Console.WriteLine("Chosissez un nombre");
            int nombre = int.Parse(Console.ReadLine());
            Console.WriteLine("Choisissez une puissance");
            int puissance = int.Parse(Console.ReadLine());

            int resultat = 1;

            for (int i = 0; i < puissance; i++)
            {
                resultat *= nombre;
            }

            Console.WriteLine("Résultat:" + resultat);
        }

        static void TPRandomV1()
        {
            Random r = new Random();
            int nb = r.Next(11);
            int resultat;
            int coups = 0;

            do
            {
                coups++;
                Console.WriteLine("Chosissez un nombre entre 0 et 10");
                resultat = int.Parse(Console.ReadLine());
            } while (resultat != nb);
            Console.WriteLine("Gagné! en "+ coups + " coups");
        }


        static void TPRandomV2()
        {
            Random r = new Random();
            int nb = r.Next(11);
            int resultat = -1;

            int tentativeMax = 2;
            int coups = 0;

            Console.WriteLine(nb);
            Console.WriteLine("Chosissez un nombre entre 0 et 10");

            do
            {
                Console.WriteLine("essaie n° "+ coups + " sur "+ tentativeMax);

                resultat = int.Parse(Console.ReadLine());
                    coups++;

                    if (resultat > nb)
                    {
                        Console.WriteLine("Plus bas");
                    }
                    else if (resultat < nb)
                    {
                        Console.WriteLine("Plus haut");
                    }
                    
                } while (coups < tentativeMax && resultat != nb);

           if (resultat == nb) {
                Console.WriteLine("Gagné! en " + coups + " coups");
                return;
            } else
            {
                Console.WriteLine("Game Over");
                return;
            }
        }
    }

   
    }
