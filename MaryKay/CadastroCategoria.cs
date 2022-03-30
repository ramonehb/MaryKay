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
    public partial class CadastroCategoria : Form
    {
        public CadastroCategoria()
        {
            InitializeComponent();
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            var voltar = new Produtos();
            voltar.ShowDialog();
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                lbErro.Text = "DIGITE O NOME";
                return;
            }
            else if (txtCategoria.Text.Length < 3)
            {
                lbErro.Text = "MINIMO 3 LETRAS";
                return;
            }
            else
            {
                lbErro.Text = string.Empty;
            }

            var tipoProduto = new Tipo_Produto();
            tipoProduto.Categoria = txtCategoria.Text;

            var categoriaDAL = new CategoriaDAL();

            if (!categoriaDAL.CadastrarCategoria(tipoProduto))
            {
                MessageBox.Show("ERRO AO CADASTRAR A CATEGORIA", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("CATEGORIA CADASTRADA", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var voltar = new Produtos();
            voltar.ShowDialog();
            this.Close();
        }
        
    }
}
