using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuantidadeDAL
    {
        public bool AlterarQuantidade(int idProduto, int quantidade)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var estoque = db.Estoques.Single(e => e.ID_Produto == idProduto);
                    estoque.QTD_Item = quantidade;
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
