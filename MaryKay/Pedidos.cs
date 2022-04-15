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
            if (Session.ID_TipoUsuario == 1)
            {
                this.Hide();
                var pedido = new PedidoNovo();
                pedido.Closed += (s, args) => this.Close();
                pedido.ShowDialog();
            }
            else
            {
                MessageBox.Show("USUÁRIO NÃO TEM PERMISSÃO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicial();
            telaInicial.Closed += (s, args) => this.Close();
            telaInicial.ShowDialog();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            this.vw_VisaoVendasTableAdapter.Fill(this.viewVendas.vw_VisaoVendas);

        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            //Cancelar a venda
        }

        private void tsbFechar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var voltar = new TelaInicial();
            voltar.Closed += (s, args) => this.Close();
            voltar.ShowDialog();
        }
    }
}
