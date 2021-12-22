using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProdutoDAL
    {
        public bool CadastrarProduto(Produto produto)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    db.Produtos.InsertOnSubmit(produto);
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
