using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPersonneV5
{
    class Groupe
    {
        private string nom;
        private Personne[] tab;
        private const int defaut_size = 10;

        public Groupe(string nom)
        {
            this.nom = nom;
            tab = new Personne[defaut_size];
        }
        public Groupe(string nom, int taille)
        {
            this.nom = nom;
            tab = new Personne[taille];
        }

        public bool Ajouter(Personne p)
        {

            for (int i = 0; i < tab.Length; i++)
                if (tab[i] == null)
                {
                    tab[i] = p;
                    return true;
                }
            return false;
            //bool exit = false;
            //for (int i = 0; i < tab.Length; i++)
            //    if (tab[i] == null)
            //    {
            //        tab[i] = p;
            //        exit = true;
            //        break;
            //    }

            //return exit;
        }

        public bool Supprimer(Personne p)
        {
            bool reponse = false;
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] != null && tab[i].Id == p.Id)
                {
                    tab[i] = null;
                    reponse = true;
                    break;

                }

            return reponse;
        }

        public int GetCount()
        {
            int count = 0;
            foreach (Personne p in tab)
                if (p != null)
                    count++;

            return count;
        }

        public override string ToString()
        {
            string reponse = nom.ToUpper() + " TAILLE " + tab.Length + "\n";
            foreach (Personne p in tab)
                if (p != null)
                    reponse += p + "\n";
            return reponse;
        }
    }
}
