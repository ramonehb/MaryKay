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
            //Confirmar o encerramento da aplicação
            Application.Exit();
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cliente = new Clientes();
            cliente.Closed += (s, args) => this.Close();
            cliente.ShowDialog();
            
        }

        private void bUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Closed += (s, args) => this.Close();
            cadastroUsuario.ShowDialog();
        }

        private void bProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            var produtos = new Produtos();
            produtos.Closed += (s, args) => this.Close();
            produtos.ShowDialog();
        }

        private void bEstoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            var estoque = new Estoque();
            estoque.Closed += (s, args) => this.Close();
            estoque.ShowDialog();
            
        }

        private void tsbFecharSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pedido = new Pedidos();
            pedido.Closed += (s, args) => this.Close();
            pedido.ShowDialog();

        }
    }
}
