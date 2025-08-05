using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVoiture
{
    class Voiture
    {
        private static readonly int VITESSE_MIN = 0;
        private static readonly int VITESSE_MAX = 300;
        private static readonly int VITESSE_FLASH = 120;

        private string matricule;
        private string marque;
        private int vitesse = 0;
        private int nbFlash = 0;
        private bool isStoped;

        public static int VitesseMax => VITESSE_MAX;
        public static int VitesseMin => VITESSE_MIN;
        public static int VitesseFlash => VITESSE_FLASH;

        public string Marque => marque;
        public string Matricule
        {
            get => matricule;
            set => matricule = value;
        }
        public int Vitesse
        {
            get => vitesse; 
            set {

                if (vitesse > VITESSE_MIN && vitesse <= 300)
                {
                    isStoped = value == 0;
                    vitesse = value;
                }

                if (vitesse > VITESSE_FLASH)
                {
                    nbFlash++;
                }
            }
        }

        public int NbFlash => nbFlash;
        public string Status => isStoped ? "à l'arrêt" : " en marche";

        public Voiture(string matricule, string marque)
        {
            Matricule = matricule;
            this.marque = marque;
        }

        public override string ToString()
        {
            return $"Matricule: {Matricule}, Marque: {Marque}, Vitesse: {Vitesse}, NbFlash: {NbFlash}, Statut: {Status}";
        }
    }
}
