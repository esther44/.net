using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
        public class Client
        {
            private string nom;
            private string prenom;
            private Adresse adresse;
            private Compte2 compte;

            public string Nom
            {
                set => nom = value; // écriture seule
            }

            public string Prenom
            {
                get => prenom;
                set => prenom = value;
            }

            public Adresse Adresse
            {
                get => adresse;
                set => adresse = value;
            }

            public Compte2 Compte
            {
                get => compte;
                set => compte = value;
            }

            public string NomBanque => compte.Banque;

            public override string ToString()
            {
                return $"Client : {prenom} - {adresse} - Banque : {NomBanque}";
            }

            public Client(Compte2 compte, Adresse adresse, string prenom)
            {
                this.compte = compte;
                this.adresse = adresse;
                this.prenom = prenom;
            }


    }
}
