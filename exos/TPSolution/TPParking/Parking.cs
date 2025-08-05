using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPParking
{
    class Parking
    {

        string nom;
        Voiture[] parking;
        int taille;

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public int Taille
        {
            get => taille;
            set  {
                taille = value;
                parking = new Voiture[Taille];
            }
        }

        public Parking(string nom, int taille){
            Nom = nom;
            Taille = taille;
        }

        public bool Garer(Voiture voiture)
        {
            for (int i = 0; i < parking.Length; i++)
            {
                if(parking[i] != null && parking[i].Matricule == voiture.Matricule)
                {
                    return false;
                }
            }
            for (int i = 0; i < parking.Length; i++)
                if (parking[i] == null)
                {
                    parking[i] = voiture;
                    voiture.Vitesse = 0;
                    return true;
                }
            return false;
        }

        public override string ToString()
        {
            string res = $"Parking {Nom} ({Taille} places)\n";

            for(int i = 0; i < parking.Length; i++)
            {
                if(parking[i] != null)
                {
                    res += $"- Place {i + 1} : {parking[i]}\n";
                }
                else
                {
                    res += $"- Place {i + 1} vide \n";
                }
            }
            return res;
        }
    }
}
