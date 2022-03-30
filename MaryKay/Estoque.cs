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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {

        }

        private void tsbAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {

        }

        private void tsbCategoria_Click(object sender, EventArgs e)
        {

        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'viewEstoque.vw_Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_EstoqueTableAdapter.Fill(this.viewEstoque.vw_Estoque);

        }

        private void tsbAjustarEstoque_Click(object sender, EventArgs e)
        {
            var idProduto = (int)dgvViewEstoque.CurrentRow.Cells["iDProdutoDataGridViewTextBoxColumn"].Value;
            try
            {
                using (var db = new BaseDataContext())
                {
                    var produto = db.Produtos.Single(p => p.ID_Produto == idProduto);
                    var alterar = new AlterarQuantidade(produto.ID_Produto, produto.Nome);
                    alterar.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            var tela = new TelaInicial();
            tela.ShowDialog();
            this.Close();
        }
    }
}
