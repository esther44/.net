using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetInterface
{
    interface I1
    {
        void M1();
        void M();
    }

    interface I2
    {
        void M2();
        void M();
    }

    interface I3:I1,I2
    {
        void M3();
    }
}
