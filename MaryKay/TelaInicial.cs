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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes();
            cliente.ShowDialog();
            this.Close();
        }

        private void bUsuario_Click(object sender, EventArgs e)
        {
            var cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.ShowDialog();
            this.Close();
        }

        private void bProdutos_Click(object sender, EventArgs e)
        {
            var produtos = new Produtos();
            produtos.ShowDialog();
            this.Close();
        }

        private void bEstoque_Click(object sender, EventArgs e)
        {
            var estoque = new Estoque();
            estoque.ShowDialog();
            this.Close();
        }

        private void tsbFecharSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bVendas_Click(object sender, EventArgs e)
        {
            //var vendas = new Vendas();
            //vendas.ShowDialog();
        }
    }
}
