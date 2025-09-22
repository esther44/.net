using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Item
    {
        private double prix;
        private string marque;


        public Item(double prix, string marque)
        {
            this.prix = prix;
            this.marque = marque;

        }

        public Item()
        {

        }

        public override string ToString()
        {
            return prix + " " + marque;
        }


        [DataMember]
        public double Prix
        {
            get { return prix; }
            set { prix = value; }

        }

        [DataMember]
        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }
    }
}
