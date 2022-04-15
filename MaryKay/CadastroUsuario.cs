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
using DAL;

namespace MaryKay
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public CadastroUsuario(int idUsuario)
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    if (ValidaUsuario())
                    {
                        var usuario = new Usuario();
                        var usuarioDAL = new UsuarioDAL();
                        var novo = string.IsNullOrEmpty(txtIdUsuario.Text);

                        if (!novo)
                        {
                            usuario.ID_Usuario = int.Parse(txtIdUsuario.Text);
                        }
                        var tipoUsuario = int.Parse(cboTipoUsuario.SelectedValue.ToString());

                        usuario.Usuario1 = txtNome.Text;
                        usuario.Senha = txtSenha.Text;
                        usuario.ID_TipoUsuario = tipoUsuario;
                        usuario.Email = tEmail.Text;
                        usuario.FL_Habilitado = cbHabilitado.Checked;
                        usuario.QtdAcesso = 0;

                        if (novo)
                        {
                            if (!usuarioDAL.CadastraUsuario(usuario))
                            {
                                MessageBox.Show("ERRO AO CADASTRAR O USUÁRIO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            MessageBox.Show("USUÁRIO CADASTRADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (!usuarioDAL.AtualizarUsuario(usuario))
                            {
                                MessageBox.Show("ERRO AO ATUALIZAR O USUÁRIO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            MessageBox.Show("USUÁRIO ATUALIZADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        LimparFormulario();
                        this.Hide();
                        var voltar = new TelaInicial();
                        voltar.Closed += (s, args) => this.Close();
                        voltar.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        private bool ValidaUsuario()
        {
            var erro = 0;

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lbNome.Text = "DIGITE O LOGIN";
                erro++;
            }
            else
            {
                lbNome.Text = string.Empty;
            }

            if(string.IsNullOrEmpty(tEmail.Text) || string.IsNullOrWhiteSpace(tEmail.Text))
            {
                lEmail.Text = "DIGITE O E-MAIL";
                erro++;
            }
            else
            {
                lEmail.Text = string.Empty;
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

        public void LimparFormulario()
        {
            txtNome.Text = string.Empty;
            tEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmaSenha.Text = string.Empty;
            cbHabilitado.Checked = true;
            cboTipoUsuario.SelectedValue = "1";
        }
    }
}
