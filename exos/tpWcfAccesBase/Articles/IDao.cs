using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    interface IDao<T, PK>
    {
        List<T> SelectAll();
    }
}
