using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaryKay
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var idPedido = 0;

                    var pedido = db.Pedidos.Where(p => p.ID_Pedido >= 1);
                    idPedido = pedido.Count() + 1;

                    var pedidoNovo = new PedidoNovo(idPedido);
                    pedidoNovo.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicial();
            telaInicial.ShowDialog();
            this.Close();
        }
    }
}
