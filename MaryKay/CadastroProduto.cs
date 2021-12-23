using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaryKay
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
            nudVL_Pago.Controls.RemoveAt(0);
            nudVL_Venda.Controls.RemoveAt(0);
            nudPontos.Controls.RemoveAt(0);
            nudCodigoRapido.Controls.RemoveAt(0);
            nudQuantidade.Text = string.Empty;
            nudVL_Pago.Text = string.Empty;
            nudVL_Venda.Text = string.Empty;
            nudCodigoRapido.Text = string.Empty;
            nudPontos.Text = string.Empty;
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'maryKayDataSet1.Tipo_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tipo_ProdutoTableAdapter.Fill(this.maryKayDataSet1.Tipo_Produto);
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.ShowDialog();
            this.Close();
        }

        private bool ValidaProduto()
        {
            var erro = 0;

            if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                erro++;
                lbNomeProduto.Text = "DIGITE O NOME DO PRODUTO";
            }
            else
            {
                lbNomeProduto.Text = string.Empty;
            }

            if (cboTipoProduto.SelectedValue == null)
            {
                erro++;
                lbCategoria.Text = "SELECIONE A CATEGORIA";

            }
            else
            {
                lbCategoria.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(nudQuantidade.Text))
            {
                erro++;
                lbQuantidade.Text = "DIGITE A QUANTIDADE";
            }
            else
            {
                lbQuantidade.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(nudVL_Pago.Text))
            {
                erro++;
                lbPago.Text = "DIGITE UM VALOR";
            }
            else
            {
                lbPago.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(nudVL_Venda.Text))
            {
                erro++;
                lbVenda.Text = "DIGITE UM VALOR";
            }
            else
            {
                lbVenda.Text = string.Empty;
            }

            if (cboSessao.SelectedItem == null)
            {
                erro++;
                lbSessao.Text = "SELECIONE";
            }
            else
            {
                lbSessao.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(nudCodigoRapido.Text))
            {
                erro++;
                lbCodigoRapido.Text = "DIGITE O CODIGO RAPIDO";
            }
            else
            {
                using (var db = new BaseDataContext())
                {
                    var codigoExistente = db.Produtos.Any(p => p.Codigo == int.Parse(nudCodigoRapido.Text));
                    if (codigoExistente)
                    {
                        erro++;
                        lbCodigoRapido.Text = "CODIGO RAPIDO JÁ CADASTRADO TENTE OUTRO";
                    }
                    else
                    {
                        lbCodigoRapido.Text = string.Empty;
                    }
                }                
            }
            if (!string.IsNullOrEmpty(nudVL_Pago.Text) && !string.IsNullOrEmpty(nudVL_Venda.Text))
            {
                if (decimal.Parse(nudVL_Pago.Text) > decimal.Parse(nudVL_Venda.Text))
                {
                    lbPago.Text = "O VALOR PAGO NÂO PODE SER MAIOR QUE O DE VENDA";
                    erro++;
                }
                else
                {
                    lbPago.Text = string.Empty;
                }
            }
            

            return erro == 0;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidaProduto())
            {
                var produto = new Produto();
                produto.Nome = txtNomeProduto.Text;
                produto.ID_TipoProduto = (int) cboTipoProduto.SelectedValue;
                produto.Codigo = int.Parse(nudCodigoRapido.Text);
                produto.Ponto = int.Parse(nudPontos.Text);
                produto.VL_Pago = decimal.Parse(nudVL_Pago.Text);
                produto.VL_Venda = decimal.Parse(nudVL_Venda.Text);
                produto.Sessao = int.Parse((string)cboSessao.SelectedItem);

                var produtoDAL= new ProdutoDAL();

                if (!produtoDAL.CadastrarProduto(produto, int.Parse(nudQuantidade.Text)))
                {
                    MessageBox.Show("ERRO AO CADASTRAR O PRODUTO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NovoProduto();
                    return;
                }

                MessageBox.Show("PRODUTO CADASTRADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NovoProduto();
                Clientes voltar = new Clientes();
                voltar.ShowDialog();
                this.Close();
            }
        }

        private void NovoProduto()
        {
            txtNomeProduto.Text = string.Empty;
            nudQuantidade.Text = string.Empty;
            nudVL_Pago.Text = string.Empty;
            nudVL_Venda.Text = string.Empty;
            nudCodigoRapido.Text = string.Empty;
            nudPontos.Text = string.Empty;
            cboSessao.SelectedItem = null;
        }
    }
}
