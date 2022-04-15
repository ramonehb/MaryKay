using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace MaryKay
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ValidaUsuario();

        }

        private bool ValidaUsuario()
        {
            var erro = 0;

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lbNome.Text = "DIGITE O NOME";
                erro++;
            }
            else
            {
                lbNome.Text = string.Empty;
            }

            if(string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lEmail.Text = "DIGITE O E-MAIL";
                erro++;
            }
            else
            {
                txtEmail.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                lbSenha.Text = "DIGITE A SENHA";
                erro++;
            }
            else
            {
                lbSenha.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(txtConfirmaSenha.Text) || string.IsNullOrWhiteSpace(txtConfirmaSenha.Text))
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
                    txtSenha.Text = string.Empty;
                    txtConfirmaSenha.Text = string.Empty;
                    erro++;
                }
                else
                {
                    lbSenha.Text = string.Empty;
                    lbConfirmaSenha.Text = string.Empty;
                }
            }

            if (string.IsNullOrEmpty(cboTipoUsuario.SelectedValue.ToString()))
            {
                lTipoUsuario.Text = "SELECIONE O TIPO DO USUÁRIO";
                erro++;
            }
            else
            {
                lTipoUsuario.Text = string.Empty;
            }

            return erro == 0;
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var voltar = new TelaInicial();
            voltar.Closed += (s, args) => this.Close();
            voltar.ShowDialog();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            this.tipoUsuarioTableAdapter.Fill(this.comboBoxTipoUsuario.TipoUsuario);

        }
    }
}
