using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSerialisation
{
    [Serializable]
    class Item
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public Item()
        {
        }

        public Item(string name)
        {
            this.name = name;


        }

        public override string ToString()
        {
            return name;
        }
    }
}
