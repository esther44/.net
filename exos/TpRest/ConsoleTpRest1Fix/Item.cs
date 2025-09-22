using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleTpRest1Fix
{
    public class Item
    {
        [JsonProperty("Ref")]
        public int Ref { get; set; }

        [JsonProperty("Marque")]
        public string Marque { get; set; }

        [JsonProperty("Prix")]
        public double Prix { get; set; }

        public Item(int refArticle, string marque, double prix)
        {
            Marque = marque;
            Prix = prix;
            Ref = refArticle;
        }

        public Item()
        {

        }

        public override string ToString()
        {
            return Ref + "   " + Marque + "   " + Prix;
        }
    }
}
