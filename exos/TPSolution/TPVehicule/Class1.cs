using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVehicule
{
    class Vehicule
    {
        protected string Marque { get; }
        protected int Prix{ get; }

        public Vehicule()
        {

        }
        public Vehicule(string m, int p)
        {
            Marque = m;
            Prix = p;
        }

        public string Avancer()
        {
            return "je roule ";
        }
    }

    class Voiture:Vehicule
    {
        public bool GpsActif { get; private set; } = false;
        public Voiture()
        {

        }
        public Voiture(string marque, int prix):base(marque, prix)
        {

        }

        public void ToggleGps()
        {
            GpsActif = !GpsActif;
        }

        public override string ToString()
        {
            return Marque + " " + Prix + " gps:" + (GpsActif ? "on" : "off");
        }
    }

    class Velo : Vehicule
    {
        public Velo(string marque, int prix) : base(marque, prix)
        {

        }

        public Velo()
        {

        }

        public new string Avancer()
        {
           return base.Avancer() + "à deux roues";
        }
    }

    class Bateau : Vehicule
    {
        public enum Taille { petit = 2, moyen = 4, grand = 10 };
        public Taille? taille;
        private bool IsAmarre { get; set; }

        public Bateau(string marque, int prix):base(marque, prix)
        {

        }

        public Bateau(string marque, int prix, Taille t) : base(marque, prix)
        {
            taille = t;
        }
        public new string Avancer()
        {
            return "je flotte";
        }

        public bool ToggleAmarre()
        {
            IsAmarre = !IsAmarre;
            return IsAmarre;
        }

        public override string ToString()
        {
            return Marque + " " + Prix + " ammaré:" + (IsAmarre ? "on" : "off") + "taille " + taille;
        }
    }
}
