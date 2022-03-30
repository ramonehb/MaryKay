using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemPedidoDAL
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public ItemPedidoDAL(int quantidade, double preco)
        {
            Quantidade = quantidade;
            Preco = preco;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }
    }
}
