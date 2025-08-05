using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCommercial
{
    class Commercial
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Commercial(string id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }

        public override string ToString()
        {
            return $"Commercial {Prenom} {Nom} (ID: {Id})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Commercial other)
            {
                return Id == other.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id != null ? Id.GetHashCode() : 0;
        }
    }
}
