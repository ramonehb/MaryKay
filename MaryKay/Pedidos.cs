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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            
            var pedidoNovo = new PedidoNovo();
            pedidoNovo.ShowDialog();
            this.Close();
              
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicial();
            telaInicial.ShowDialog();
            this.Close();
        }
    }
}
