using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProdutoDAL
    {
        public bool CadastrarProduto(Produto produto, int quantidade)
        {
            try
            {
                
                using (var db = new BaseDataContext())
                {
                    db.Produtos.InsertOnSubmit(produto);
                    db.SubmitChanges();
                    db.usp_AlterarEstoque(produto.ID_Produto, quantidade);
                    return true;
                }
            }
            catch (Exception erro)
            {
                var msg = erro.Message;
                return false;
            }
        }

        public bool AlterarProduto(Produto produto, int quantidade)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var produtoAtualizado = db.Produtos.Single(p => p.ID_Produto == produto.ID_Produto);
                    produtoAtualizado.ID_TipoProduto = produto.ID_TipoProduto;
                    produtoAtualizado.Nome = produto.Nome;
                    produtoAtualizado.Codigo = produto.Codigo;
                    produtoAtualizado.Ponto = produto.Ponto;
                    produtoAtualizado.VL_Pago = produto.VL_Pago;
                    produtoAtualizado.VL_Venda = produto.VL_Venda;
                    //produtoAtualizado.Quantidade = produto.Quantidade;
                    produtoAtualizado.Sessao = produto.Sessao;

                    db.SubmitChanges();
                    db.usp_AlterarEstoque(produtoAtualizado.ID_Produto, quantidade);
                    
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
