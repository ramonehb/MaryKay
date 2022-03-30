using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PedidoDAL
    {
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime  Data { get; set; }
        public PedidoStatus Status { get; set; }

        public List<ItemPedidoDAL> Items = new List<ItemPedidoDAL>();

        public PedidoDAL(Cliente cliente,Usuario usuario, DateTime data, PedidoStatus status)
        {
            Cliente = cliente;
            Usuario = usuario;
            Data = data;
            Status = status;
        }

        public void addItem(ItemPedidoDAL item)
        {
            Items.Add(item);
        }

        public void removerItem(ItemPedidoDAL item)
        {
            Items.Remove(item);
        }

        public Double ValorTotal()
        {
            double sum = 0;
            foreach (var item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }
    }
}
