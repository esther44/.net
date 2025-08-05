using System;

namespace TPProjet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création des postes
            Poste poste1 = new Poste("Poste1");
            Poste poste2 = new Poste("Poste2");

            // Chaque poste enregistre les imprimantes (en interne il délègue au centraliseur)
            poste1.AjouterImprimante("A1", true);
            poste1.AjouterImprimante("A2", false); // hors service
            poste2.AjouterImprimante("A1", false);

            // Demandes d’impression
            poste1.Print("Document 1");
            poste2.Print("Document 2");

            // Simulation de panne via poste
            poste1.MettreImprimanteHorsService("A1");

            poste1.Print("Document 3");
            poste2.Print("Document 4");

            poste2.MettreImprimanteHorsService("A2");

            poste1.Print("Document 5");

            Console.ReadLine();
        }
    }
}
