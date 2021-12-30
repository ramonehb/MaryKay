using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaDAL
    {
        public bool CadastrarCategoria(Tipo_Produto tipo_Produto)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    db.Tipo_Produtos.InsertOnSubmit(tipo_Produto);
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
