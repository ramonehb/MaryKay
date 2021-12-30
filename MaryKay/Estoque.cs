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
            this.vw_EstoqueTableAdapter2.Fill(this.dataSetEstoques.vw_Estoque);
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            var idProduto = (int) dgvEstoque.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value;
            var nomeProduto = dgvEstoque.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
            var alterarQuantidade = new AlterarQuantidade(idProduto, nomeProduto);
            alterarQuantidade.ShowDialog();
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            var voltar = new TelaInicial();
            voltar.ShowDialog();
            this.Close();
        }
    }
}
