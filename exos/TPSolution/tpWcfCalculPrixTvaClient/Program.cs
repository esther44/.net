using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpWcfCalculPrixTvaClient.Calcul;

namespace tpWcfCalculPrixTvaClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculeServiceClient service = new CalculeServiceClient();

            try
            {
                Console.Write("Quantité : ");
                int quantite = int.Parse(Console.ReadLine());

                Console.Write("Prix unitaire : ");
                double prix = double.Parse(Console.ReadLine());

                Console.Write("Nom de l'article : ");
                string nomArticle = Console.ReadLine();

                Console.WriteLine("Catégorie :");
                var categories = Enum.GetValues(typeof(TVAServiceETVA));
                for (int i = 0; i < categories.Length; i++)
                {
                    Console.WriteLine($"{i} - {categories.GetValue(i)}");
                }

                Console.Write("Votre choix : ");
                int choix = int.Parse(Console.ReadLine());
                TVAServiceETVA categorie = (TVAServiceETVA)categories.GetValue(choix);

                double tva = service.Calcule(quantite, nomArticle, prix, categorie);

                Console.WriteLine($"\nPour {quantite} {nomArticle} à {prix:F2} € pièce, vous récupérez {tva:F2} € de TVA");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
            finally
            {
                service.Close();
            }
        }
    }
}
