using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInterface
{
    public interface I1
    {
       void M1();
    }

    public interface I2
    {
       void M2();
    }

    public interface I3:I1,I2
    {
       void M3();
    }
}
