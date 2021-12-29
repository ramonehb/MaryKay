using DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MaryKay
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente(int idCliente)
        {
            InitializeComponent();
            btnFinalizar.Text = idCliente == 0 ? "FINALIZAR" : "ATUALIZAR";

            if (idCliente != 0)
            {
                txtIdCliente.Text = idCliente.ToString();
                CarregaCliente(idCliente);
            }
            else
            {
                NovoCliente();
            }

            dtNascimento.MaxDate = DateTime.Now;
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidaCamposObrigatorios())
            {
                var cliente = new Cliente();
                var novo = string.IsNullOrEmpty(txtIdCliente.Text) ? true : false;

                if (!novo)
                {
                    cliente.ID_Cliente = int.Parse(txtIdCliente.Text);
                }

                cliente.Nome = txtNome.Text;
                cliente.CPF = string.IsNullOrEmpty(mtbCpf.Text.Replace(".", "").Replace("-", "").Replace(" ", "")) ? null : mtbCpf.Text.Replace(".", "").Replace("-", "");
                cliente.Email = string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text;
                cliente.DT_Nascimento = dtNascimento.Value;
                cliente.Telefone = mtbTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                cliente.Rua = string.IsNullOrEmpty(txtRua.Text) ? null : txtRua.Text;
                cliente.CEP = string.IsNullOrEmpty(mtbCEP.Text.Replace("-", "").Replace(" ", "")) ? 0000000 : int.Parse(mtbCEP.Text.Replace("-", ""));
                cliente.NR_Logradouro = string.IsNullOrEmpty(txtNumero.Text) ? 0 : int.Parse(txtNumero.Text);
                cliente.Cidade = txtCidade.Text;
                cliente.Estado = txtEstado.Text;
                cliente.FL_EnviaEmail = checkEmail.Checked;

                var clienteDal = new ClienteDAL();

                if (novo)
                {
                    if (!clienteDal.CadastraCliente(cliente))
                    {
                        MessageBox.Show("ERRO AO CADASTRAR O CLIENTE", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("CLIENTE CADASTRADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!clienteDal.AtualizarCliente(cliente))
                    {
                        MessageBox.Show("ERRO AO ATUALIZAR O CLIENTE", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("CLIENTE ATUALIZADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                var voltar = new Clientes();
                voltar.ShowDialog();
                this.Close();
            }
        }

        private void NovoCliente()
        {
            txtIdCliente.Text = string.Empty;
            txtNome.Text = string.Empty;
            lNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mtbCpf.Text = string.Empty;
            mtbCEP.Text = string.Empty;
            txtRua.Text = string.Empty;
            mtbTelefone.Text = string.Empty;
            lTelefone.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
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

            if (mtbCpf.Text.Replace(".", "").Replace("-", "").Length == 11)
            {
                var cpf = mtbCpf.Text.Replace(".", "").Replace("-", "");
                if (!Funcoes.Funcoes.VerificaCPF(cpf))
                {
                    erro++;
                    lbCpf.Text = "INFORME UM CPF VALIDO";
                }
                else
                {
                    lbCpf.Text = string.Empty;
                }
            }
            else if (!string.IsNullOrEmpty(mtbCpf.Text.Replace(".", "").Replace("-", "").Replace(" ", "")))
            {
                erro++;
                lbCpf.Text = "PREENCHA O CPF CORRETAMENTE";
            }
            else
            {
                lbCpf.Text = string.Empty;
            }

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!Funcoes.Funcoes.VerificarEmail(txtEmail.Text))
                {
                    erro++;
                    lbEmail.Text = "O E-MAIL PRECISA TER @ E .COM";
                }
                else
                {
                    lbEmail.Text = string.Empty;
                }
            }

            return erro == 0;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                checkEmail.Enabled = true;
            }
            else
            {
                checkEmail.Enabled = false;
                checkEmail.Checked = false;
            }
        }

        private void CarregaCliente(int idCliente)
        {
            if (idCliente != 0)
            {
                using (var db = new BaseDataContext())
                {
                    try
                    {
                        var cliente = db.Clientes.Single(c => c.ID_Cliente == idCliente);
                        txtNome.Text = cliente.Nome;
                        txtEmail.Text = cliente.Email;
                        mtbCpf.Text = cliente.CPF;
                        mtbCEP.Text = cliente.CEP.ToString();
                        txtRua.Text = cliente.Rua;
                        mtbTelefone.Text = cliente.Telefone;
                        txtEstado.Text = cliente.Estado;
                        txtCidade.Text = cliente.Cidade;
                        txtNumero.Text = cliente.NR_Logradouro.ToString();
                        dtNascimento.Value = (DateTime)cliente.DT_Nascimento;
                        checkEmail.Checked = cliente.FL_EnviaEmail ?? false;
                    }
                    catch (Exception erro)
                    {
                        var msg = erro.Message;
                    }
                }
            }

        }
    }
}
