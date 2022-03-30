using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace MaryKay
{
    public partial class AlterarQuantidade : Form
    {
        private int idProduto;
        private string nomeProduto;

        public AlterarQuantidade(int id, string nome)
        {
            InitializeComponent();
            idProduto = id;
            nomeProduto = nome;
            nudAtual.Controls.RemoveAt(0);
            nudNovo.Controls.RemoveAt(0);
            nudNovo.Text = string.Empty;
            lbProduto.Text = "PRODUTO: " + nome;
            CarregaAtual();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nudNovo.Text))
            {
                lbNovaErro.Text = "DIGITE A NOVA QUANTIDADE";
                return;
            }
            else
            {
                lbNovaErro.Text = string.Empty;
            }

            var quantidadeDAL = new QuantidadeDAL();
            if (!quantidadeDAL.AlterarQuantidade(idProduto, int.Parse(nudNovo.Text)))
            {
                MessageBox.Show("ERRO AO ATUALIZAR A QUANTIDADE", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(nomeProduto +"  QUANTIDADE ATUALIZADA", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //var estoque = new Estoque();
            //estoque.ShowDialog();
        }

        private void CarregaAtual()
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var produto = db.Estoques.Single(e => e.ID_Produto == idProduto);
                    nudAtual.Text = produto.QTD_Item.ToString();
                }
            }
            catch (Exception erro)
            {
                var msg = erro;
            }
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            //var estoque = new Estoque();
            //estoque.ShowDialog();
            //this.Close();
        }
    }
}
