using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCoordonnées
{
    class DeuxDim
    {
        protected int x;
        protected int y;
        public DeuxDim() : base()
        {
            Console.WriteLine("cest le par defaut DeuxDim");
        }

        public DeuxDim(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {

            return x + "     " + y;
        }
    }

    class TroisDim : DeuxDim
    {
        private int z;

        public TroisDim()//base()
        {
            Console.WriteLine("cest le par defaut TroisDim");

        }

        //public TroisDim(int toto, int y, int z):base(toto,y)
        //{
        //    this.x = toto;
        //    //this.y = y;
        //    this.z = z;

        //}

        public override string ToString()
        {
            return base.ToString() + "       " + z;
        }
    }

    class QuatreDim : TroisDim
    {
        //public QuatreDim()//:base()
        //{
        //    Console.WriteLine("cest le par defaut QuatreDim");
        //}

        //le const implicite de QuatreDim va appeler implicitement le const defaut du dessus
    }
}
