using DAL;
using MaryKay.Classes;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var erro = 0;
                if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrWhiteSpace(txtLogin.Text))
                {
                    lLogin.Text = "DIGITE O USUÁRIO";
                    erro++;
                }
                else
                {
                    lLogin.Text = string.Empty;
                }

                if (string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    lSenha.Text = "DIGITE A SENHA";
                    erro++;
                }
                else
                {
                    lSenha.Text = string.Empty;
                }

                if (erro == 0)
                {
                    using (var db = new BaseDataContext())
                    {
                        var usuario = db.Usuarios.SingleOrDefault(u => u.Usuario1.ToUpper() == txtLogin.Text.ToUpper() && u.Senha == Criptografia.Hash(txtSenha.Text));

                        if (usuario == null)
                        {
                            MessageBox.Show("USUÁRIO NÃO LOCALIZADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtLogin.Text = string.Empty;
                            txtSenha.Text = string.Empty;
                            return;
                        }

                        usuario.QtdAcesso += 1;
                        db.SubmitChanges();

                        Session.ID_Usuario = usuario.ID_Usuario;
                        Session.Login = usuario.Usuario1;
                        Session.ID_TipoUsuario = usuario.ID_TipoUsuario;
                        Session.QtdAcesso = (int)usuario.QtdAcesso;

                        this.Hide();
                        TelaInicial telaInicial = new TelaInicial();
                        telaInicial.Closed += (s, args) => this.Close();
                        telaInicial.ShowDialog();

                        usuario = null;
                    }
                }
            }
            catch (Exception ex )
            {
                var msg = ex.Message;
            }
        }

        private void tsbFecharSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
