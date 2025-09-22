using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetException2
{
    class Calcul
    {
        public static int Div(int a, int b)
        {
            if (b == 0)
            {
                DivideByZeroException x = new DivideByZeroException("anomalie technique attention denom a zero");
                throw x;
            }

            if (a == 0)
            {
                NumeratorException x = new NumeratorException();
                throw x;
            }
            return a / b;
        }
    }
}
