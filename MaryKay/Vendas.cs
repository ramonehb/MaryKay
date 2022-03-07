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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetProdutosVenda.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dataSetProdutosVenda.Produto);

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var produto = db.Produtos.Single(p => p.ID_Produto == int.Parse(cboProduto.SelectedValue.ToString()));
                    dgvCarrinhoVenda.DataSource = produto;

                    var refesh = new Vendas();
                    refesh.ShowDialog();
                }
                
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
}
