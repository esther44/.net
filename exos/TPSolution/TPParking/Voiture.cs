using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPParking
{
    class Voiture
    {

        int vitesse = 0;
        string matricule;
        string marque;
        double prix;

        public string Marque
            {
                get => marque;
                set => marque = value;
            }
        public string Matricule
        {
            get => matricule;
            set => matricule = value;
        }
        public int Vitesse
        {
            get => vitesse;
            set => vitesse = value;
       
        }

        public double Prix
        {
            get => prix;
            set => prix = value;
       
        }

        public Voiture(string matricule, string marque, double prix)
        {
            Matricule = matricule;
            Marque = marque;
            Prix = prix;
        }

        public override string ToString()
        {
            return $"Voiture {Marque}, Matricule: {Matricule}, Prix: {Prix}€, Vitesse: {Vitesse} km/h";
        }
    }
}
