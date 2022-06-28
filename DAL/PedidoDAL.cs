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
        //public Usuario Usuario { get; set; }
        public DateTime Data { get; set; }
        public int Status { get; set; }

        public List<ItemPedidoDAL> Items = new List<ItemPedidoDAL>();

        public PedidoDAL() { }

        public PedidoDAL(Cliente cliente, DateTime data, int status)
        {
            Cliente = cliente;
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
                sum += item.SubTotal;
            }

            return sum;
        }
    }
}
