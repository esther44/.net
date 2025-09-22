using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleServiceRest1
{
    class Personne
    {
        [JsonProperty("Id")]
        public int Id { get; set; }


        [JsonProperty("Nom")]
        public string Nom { get; set; }


        [JsonProperty("Prenom")]
        public string Prenom { get; set; }

        public Personne(int id, string nom, string prenom)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
        }


        public override string ToString()
        {
            return Id+ "  " + Nom + "   " + Prenom;
        }
    }
}
