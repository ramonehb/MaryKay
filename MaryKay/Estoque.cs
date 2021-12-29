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

        private void tsbVoltar_Click(object sender, EventArgs e)
        {
            var voltar = new TelaInicial();
            voltar.ShowDialog();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'maryKayDataSet2.vw_Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_EstoqueTableAdapter1.Fill(this.maryKayDataSet2.vw_Estoque);
            //this.vw_EstoqueTableAdapter.Fill(this.dataSetViewEstoque.vw_Estoque);
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            var idProduto = (int) dgvEstoque.CurrentRow.Cells["iDProdutoDataGridViewTextBoxColumn"].Value;
            var nomeProduto = dgvEstoque.CurrentRow.Cells["nOMEDataGridViewTextBoxColumn"].Value.ToString();
            var alterarQuantidade = new AlterarQuantidade(idProduto, nomeProduto);
            alterarQuantidade.ShowDialog();
        }
    }
}
