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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ValidaUsuario();
        }

        private bool ValidaUsuario()
        {
            var erro = 0;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                lbNome.Text = "DIGITE O NOME";
                erro++;
            }
            else
            {
                lbNome.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                lbSenha.Text = "DIGITE A SENHA";
                erro++;
            }
            else
            {
                lbSenha.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(txtConfirmaSenha.Text))
            {
                lbConfirmaSenha.Text = "CONFIRME A SENHA";
                erro++;
            }
            else
            {
                if (txtSenha.Text != txtConfirmaSenha.Text)
                {
                    lbSenha.Text = "AS SENHAS DEVEM SER IGUAIS!";
                    lbConfirmaSenha.Text = "AS SENHAS DEVEM SER IGUAIS!";
                }else
                {
                    lbSenha.Text = string.Empty;
                    lbConfirmaSenha.Text = string.Empty;
                }
            }

            
            

            return erro == 0;
        }

    }
}
