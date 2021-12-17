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
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.ShowDialog();
            this.Close();
        }

        private void bUsuario_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.ShowDialog();
            this.Close();
        }
    }
}
