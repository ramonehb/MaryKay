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
        public string cpf { get; set; }

        public int cep { get; set; }
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidaCliente())
            {
                //Cadastrar com os dados da tela
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
            lCPF.Text = string.Empty;
            mtbCEP.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtNumero.Text = string.Empty;
        }

        private bool ValidaCliente()
        {
            var erro = 0;

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lNome.Text = "DIGITE O NOME";
                erro++;
            }
            if(string.IsNullOrEmpty(mtbCpf.Text.Replace(".", "").Replace("-", "").Replace(" ", "")) || mtbCpf.Text.Length < 13)
            {
                lCPF.Text = "DIGITE O CPF / CPF INVALIDO";
                erro++;
            }
            //Conversão de dados
            //cpf = mtbCpf.Text.Replace(".", "").Replace("-", "").Replace(" ", "");
            //cep = int.Parse(mtbCEP.Text.Replace("-", ""));
            return erro == 0;
        }
    }
}
