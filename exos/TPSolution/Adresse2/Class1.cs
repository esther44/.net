using System;

namespace Model
{
    public class Adresse
    {
        private string rue;
        private string ville;
        private string pays;

        public Adresse(string ville, string rue, string pays)
        {
            this.rue = rue;
            this.ville = ville;
            this.pays = pays;
        }

        public string Rue
        {
            get => rue;
            set => rue = value;
        }

        public string Ville
        {
            get => ville;
            set => ville = value;
        }

        public string Pays
        {
            get => pays;
            set => pays = value;
        }

        public override string ToString()
        {
            return $"{Rue}, {Ville}, {Pays}";
        }
    }
}
