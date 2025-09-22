using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Articles
{
    [DataContract]
    public class Article
    {
        private int id;
        private string marque;
        private int price;

        [DataMember]
        public int Id
        {
            get
            {
                return id;
            }
            set => id = value;
        }

        [DataMember]
        public string Marque
        {
            get
            {
                return marque;
            }
            set => marque = value;
        }

        [DataMember]
        public int Price
        {
            get
            {
                return price;
            }
            set => price = value;
        }


        public Article(int id, string marque, int price)
        {
            this.Id = id;
            this.Marque = marque;
            this.Price = price;
        }

        public Article() { }

        public override string ToString()
        {
            return id + " " + marque + " " + price;
        }
    }
}
