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
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.ShowDialog();
            this.Close();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.ShowDialog();
            this.Close();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'maryKayDataSet3.vw_Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.vw_ProdutosTableAdapter.Fill(this.maryKayDataSet3.vw_Produtos);
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var produtoFiltro = db.vw_Produtos.Where(p => p.NOME.Contains(txtBusca.Text));
                    dgvProdutos.DataSource = produtoFiltro;
                }
            }
            catch (Exception erro)
            {
                var msg = erro.Message;
                throw;
            }
        }
    }
}
