using System;
using System.Collections.Generic;
using System.Linq;

namespace TPProjet
{
    public class Centraliseur
    {
        private static Centraliseur instance = null;
        private List<Imprimante> imprimantes = new List<Imprimante>();
        private int indexRoundRobin = 0;

        private Centraliseur() { }

        public static Centraliseur Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Centraliseur();
                }
                return instance;
            }
        }

        public void AjouterImprimante(string num, bool statut)
        {
            imprimantes.Add(new Imprimante(num, statut));
        }

        public void MettreImprimanteHorsService(string num)
        {
            var imp = imprimantes.FirstOrDefault(i => i.Num == num);
            if (imp != null) imp.Statut = false;
        }

        public void PrintDepuisPoste(string posteNom, string message)
        {
            Console.WriteLine($"[{posteNom}] demande d'impression : {message}");

            for (int i = 0; i < imprimantes.Count; i++)
            {
                indexRoundRobin = (indexRoundRobin + 1) % imprimantes.Count;
                var imprimante = imprimantes[indexRoundRobin];

                if (imprimante.Statut)
                {
                    imprimante.Print(message);
                    return;
                }
            }

            Console.WriteLine($"[Centraliseur] Aucune imprimante disponible pour imprimer le message de {posteNom}.");
        }
    }
}
