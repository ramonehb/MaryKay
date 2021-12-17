using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        public static IQueryable<Cliente> GetDadosCliente()
        {
            var db = new BaseDataContext();
            return db.GetTable<Cliente>();
        }
    }
}
