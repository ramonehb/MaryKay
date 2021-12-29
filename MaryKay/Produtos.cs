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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void tsbVoltar_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicial();
            telaInicial.ShowDialog();
            this.Close();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            var cadastroProduto = new CadastroProduto(0);
            cadastroProduto.ShowDialog();
            this.Close();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            this.vw_ProdutosTableAdapter3.Fill(this.dataSetViewProdutos.vw_Produtos);
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var produtoFiltro = db.vw_Produtos.Where(p => p.NOME.Contains(txtFiltroProduto.Text));
                    dgvProdutos.DataSource = produtoFiltro;
                }
            }
            catch (Exception erro)
            {
                var msg = erro.Message;
                throw;
            }
        }

        private void tsbAtualizar_Click(object sender, EventArgs e)
        {
            var idProduto = (int) dgvProdutos.CurrentRow.Cells["iDProdutoDataGridViewTextBoxColumn"].Value;
            var cadastraProduto = new CadastroProduto(idProduto);
            cadastraProduto.ShowDialog();
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            var idProduto = (int) dgvProdutos.CurrentRow.Cells["iDProdutoDataGridViewTextBoxColumn"].Value;
            var nomeCliente = dgvProdutos.CurrentRow.Cells["nOMEDataGridViewTextBoxColumn"].Value.ToString();
            var msg = "TEM CERTEZA QUE DESEJA EXCLUIR O " + nomeCliente + " ?";

            if (idProduto != 0)
            {
                var pergunta = MessageBox.Show(msg, "MARY MAY", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (pergunta == DialogResult.Yes)
                {
                    var produtoDAL = new ProdutoDAL();
                    if (!produtoDAL.DeletarProduto(idProduto))
                    {
                        MessageBox.Show("ERRO AO DELETAR O PRODUTO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("PRODUTO DELETADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var voltar = new Produtos();
                    voltar.ShowDialog();
                }
            }
        }

        private void txtBusca_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var produtoFiltrados = db.vw_Produtos.Where(p => p.NOME.Contains(txtFiltroProduto.Text));
                    dgvProdutos.DataSource = produtoFiltrados;
                }
            }
            catch (Exception erro)
            {
                var msg = erro.Message;
            }
        }
    }
}
