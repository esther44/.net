using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSingleton
{
    class Singleton
    {
        // private static Singleton instance = new Singleton();
        private static Singleton instance = null;

        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;

            }
        }

        //public static Singleton Instance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}
    }
}
