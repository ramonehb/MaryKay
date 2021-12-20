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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
            dtNascimento.MaxDate = DateTime.Now;
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.ShowDialog();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidaCamposObrigatorios())
            {
                var cliente = new Cliente();
                cliente.Nome = txtNome.Text;
                cliente.CPF = string.IsNullOrEmpty(mtbCpf.Text.Replace(".", "").Replace("-", "").Replace(" ", "")) ? null : mtbCpf.Text.Replace(".", "").Replace("-", "");
                cliente.Email = string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text;
                cliente.DT_Nascimento = dtNascimento.Value;
                cliente.Telefone = mtbTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                cliente.Rua = string.IsNullOrEmpty(txtRua.Text) ? null : txtRua.Text;
                cliente.CEP = string.IsNullOrEmpty(mtbCEP.Text.Replace("-", "").Replace(" ", "")) ? 0000000 : int.Parse(mtbCEP.Text.Replace("-", ""));
                cliente.NR_Logradouro = string.IsNullOrEmpty(txtNumero.Text) ? 0 : int.Parse(txtNumero.Text);
                cliente.FL_EnviaEmail = checkEmail.Checked;

                var clienteDal = new ClienteDAL();
                if (!clienteDal.CadastraCliente(cliente))
                {
                    MessageBox.Show("ERRO AO CADASTRAR O CLIENTE", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NovoCliente();
            }
        }

        private void NovoCliente()
        {
            txtNome.Text = string.Empty;
            lNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mtbCpf.Text = string.Empty;
            mtbCEP.Text = string.Empty;
            txtRua.Text = string.Empty;
            mtbTelefone.Text = string.Empty;
            lTelefone.Text = string.Empty;
            txtNumero.Text = string.Empty;
            dtNascimento.Value = DateTime.Parse("01-01-1990");
            checkEmail.Checked = false;
        }

        private bool ValidaCamposObrigatorios()
        {
            var erro = 0;
            var telefone = mtbTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lNome.Text = "DIGITE O NOME";
                erro++;
            }
            else
            {
                lNome.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(telefone) || telefone.Length < 11)
            {
                erro++;
                lTelefone.Text = "DIGITE O TELEFONE";
            }
            else
            {
                lTelefone.Text = string.Empty;
            }

            return erro == 0;
        }
    }
}
