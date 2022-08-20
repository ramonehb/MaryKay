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
    public partial class UsuarioGerenciamento : Form
    {
        public UsuarioGerenciamento()
        {
            InitializeComponent();
        }

        private void UsuarioGerenciamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewUsuarios.vw_Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_UsuariosTableAdapter.Fill(this.viewUsuarios.vw_Usuarios);

        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            if (Session.ID_TipoUsuario == 1)
            {
                var idUsuario = (int)dgvUsuarios.CurrentRow.Cells["iDUsuarioDataGridViewTextBoxColumn"].Value;
                var usuario = new CadastroUsuario(idUsuario);
                this.Hide();
                usuario.Closed += (s, args) => this.Close();
                usuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("USUÁRIO SEM PERMISSÃO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var usuario = new TelaInicial();
            usuario.Closed += (s, args) => this.Close();
            usuario.ShowDialog();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            if (Session.ID_TipoUsuario == 1)
            {
                this.Hide();
                var cadastro = new CadastroUsuario();
                cadastro.Closed += (s, args) => this.Close();
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("USUÁRIO SEM PERMISSÃO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (Session.ID_TipoUsuario == 1)
            {
                var idUsuario = (int)dgvUsuarios.CurrentRow.Cells["iDUsuarioDataGridViewTextBoxColumn"].Value;

                using (var db = new BaseDataContext())
                {
                    var usuario = db.Usuarios.SingleOrDefault(u => u.ID_Usuario == idUsuario);

                    if (usuario is null)
                    {
                        MessageBox.Show("USUÁRIO NÂO LOCALIZADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (Session.ID_Usuario == idUsuario)
                    {
                        MessageBox.Show("VOCÊ NÃO PODE BLOQUEAR SEU USUÁRIO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    usuario.FL_Habilitado = false;
                    db.SubmitChanges();
                    MessageBox.Show($"USUÁRIO {usuario.Usuario1} BLOQUEADO COM SUCESSO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var us = new UsuarioGerenciamento();
                    us.Closed += (s, args) => this.Close();
                    us.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("USUÁRIO SEM PERMISSÃO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
