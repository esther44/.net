using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDaoGenerique
{
    interface IDaoPersonne : IDao<Personne, int>
    {
        // crud ++
        List<Personne> FindByNom(string nom);
    }
 
}
