using projetDaoPersonneComponent.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetDaoPersonneComponent.DAO
{
    class DaoPersonne
    {

        public List<Personne> SelectAll()
        {
            return new Db().SelectAll();
        }


    }

}
