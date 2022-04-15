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
            lSessao.Text = Session.Login.ToUpper();
            lNumeroAcesso.Text = Session.QtdAcesso.ToString();
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
            if (new int[] { 1, 2}.Contains(Session.ID_TipoUsuario))
            {
                this.Hide();
                var cadastroUsuario = new UsuarioGerenciamento();
                cadastroUsuario.Closed += (s, args) => this.Close();
                cadastroUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("USUÁRIO NÃO TEM PERMISSÃO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            var pergunta = MessageBox.Show("DESEJA SAIR DO SISTEMA ?", "MARY MAY", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (pergunta == DialogResult.Yes)
            {
                Session.ID_Usuario = 0;
                Session.ID_TipoUsuario = 0;
                Session.Login = null;
                Session.QtdAcesso = 0;

                this.Hide();
                var login = new Login();
                login.Closed += (s, args) => this.Close();
                login.ShowDialog();
            }
        }

        private void bVendas_Click(object sender, EventArgs e)
        {
            if (new int[] { 1, 2 }.Contains(Session.ID_TipoUsuario))
            {
                this.Hide();
                var pedido = new Pedidos();
                pedido.Closed += (s, args) => this.Close();
                pedido.ShowDialog();
            }
            else
            {
                MessageBox.Show("USUÁRIO NÃO TEM PERMISSÃO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
