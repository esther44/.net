using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCompte
{
    class CompteSimple
    {
        private int solde;
        private const int CADEAU = 20;
        private string titulaire;
        protected virtual int Commission => 1;
        protected virtual bool EstDecouvertAutorise => false;

        public int Solde
        {
            get => solde;
            set => solde = value;
        }

        public string Titulaire
        {
            get => titulaire;
            set => titulaire = value;
        }


        public CompteSimple(string proprietaire)
        {
            Titulaire = proprietaire;
            Solde = CADEAU;
        }

        public CompteSimple(string proprietaire, int solde)
        {
            Titulaire = proprietaire;
            Solde = solde + CADEAU;
        }

        private Boolean Crediter(int somme)
        {
            int result = somme - Commission;
            if (result > 0)
            {
                Solde += result;
                Console.WriteLine("Opé Credit succès, nouveau solde " + Solde);
                return true;
            }
            Console.WriteLine("la somme a créditer trop faible");
            return false;

        }

        private bool Debiter(int somme)
        {
            if(somme > 0)
            {
                int total = (somme + Commission);
                if(!EstDecouvertAutorise && Solde - total < 0)
                {
                     Console.WriteLine("Opé Débit impossible, solde insuffisant");
                    return false;
                }
                Solde -= total;
                Console.WriteLine("Opé Débit succès, nouveau solde " + Solde);
                return true;
            }
            return false;
        }

        public bool Virement(int somme, CompteSimple compteDest)
        {
            bool debit = Debiter(somme);
            bool credit = compteDest.Crediter(somme);

            bool result = credit && debit;
            if (result)
            {
                Console.WriteLine("virement succès");
                return result;
            }
            Console.WriteLine("virement échec");
            return result;
        }
    }
}
