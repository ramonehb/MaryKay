using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL
    {
        public bool CadastraCliente(Cliente cliente)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    db.Clientes.InsertOnSubmit(cliente);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception erro)
            {
                var msg = erro.Message;
                return false;
            }
        }
    }
}
