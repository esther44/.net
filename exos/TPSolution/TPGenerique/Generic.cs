using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGenerique
{
    class Generic<X, Y, Z>
    {
        X a;
        Y b;
        Z c;

        public X A
        {
            get
            {
                return a;
            }
        }

        public Y B
        {
            get
            {
                return b;
            }
        }

        public Z C
        {
            get
            {
                return c;
            }
        }

        public Generic(X a, Y b, Z c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override string ToString()
        {
            return $"A: {a}, B: {b}, C: {c}";
        }
    }
    
    class Voiture
    {
        string marque;

        public string Marque
        {
            get
            {
                return marque;
            }
        }

        public Voiture(string marque)
        {
            this.marque = marque;
        }

        public override string ToString()
        {
            return $"Voiture maqrue: {Marque}";
        }
    }

    class Article
    {
        double prix;

        public double Prix
        {
            get
            {
                return prix;
            }
        }

        public Article(double prix)
        {
            this.prix = prix;
        }

        public override string ToString()
        {
            return $"Article prix: {Prix}";
        }
    }

    class Client
    {
        string nom;

        public string Nom
        {
            set => nom = value;
            get => nom;
           
        }

       public Client(string nom)
        {
            Nom = nom;
        }

        public override string ToString()
        {
            return $"Client nom: {Nom}";
        }
    }

}
