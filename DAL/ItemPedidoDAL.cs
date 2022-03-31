using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemPedidoDAL
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        

        public ItemPedidoDAL() { }

        public ItemPedidoDAL(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = (double) produto.VL_Venda;
        }

        public void AdicionarItem(ItemPedido itemPedido)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    db.ItemPedidos.InsertOnSubmit(itemPedido);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                throw;
            }
        }

        public double SubTotal()
        {
            return (double) Preco * Quantidade;
        }
    }
}
