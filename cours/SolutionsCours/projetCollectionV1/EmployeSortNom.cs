using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCollectionV1
{
    class EmployeSortNom : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Nom.CompareTo(y.Nom);
        }
    }

    class EmployeSortPrenom : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Prenom.CompareTo(y.Prenom);
        }
    }
}
