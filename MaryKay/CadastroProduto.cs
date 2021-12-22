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
        private Regex regex = new Regex("[0-9]");

        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'maryKayDataSet1.Tipo_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tipo_ProdutoTableAdapter.Fill(this.maryKayDataSet1.Tipo_Produto);

        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.ShowDialog();
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

            if (string.IsNullOrEmpty(txtQuantidade.Text))
            {
                erro++;
                lbQuantidade.Text = "DIGITE A QUANTIDADE";
            }
            else
            {
                lbQuantidade.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(txtVL_Pago.Text))
            {
                erro++;
                lbPago.Text = "DIGITE UM VALOR";
            }
            else
            {
                lbPago.Text = string.Empty;
            }

            if (string.IsNullOrEmpty(txtVL_Venda.Text))
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

            if (string.IsNullOrEmpty(txtCodigoRapido.Text))
            {
                erro++;
                lbCodigoRapido.Text = "DIGITE O CODIGO RAPIDO";
            }
            else
            {
                lbCodigoRapido.Text = string.Empty;
            }
            if (!string.IsNullOrEmpty(txtVL_Pago.Text) && !string.IsNullOrEmpty(txtVL_Venda.Text))
            {
                if (decimal.Parse(txtVL_Pago.Text) > decimal.Parse(txtVL_Venda.Text))
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
                produto.Codigo = int.Parse(txtCodigoRapido.Text);
                produto.Ponto = int.Parse(txtPontos.Text);
                produto.VL_Pago = decimal.Parse(txtVL_Pago.Text);
                produto.VL_Venda = decimal.Parse(txtVL_Venda.Text);
                produto.Quantidade = int.Parse(txtQuantidade.Text);
                produto.Lucro = (produto.VL_Venda - produto.VL_Pago);
                produto.Sessao = int.Parse((string)cboSessao.SelectedItem);

                var produtoDAL= new ProdutoDAL();

                if (!produtoDAL.CadastrarProduto(produto))
                {
                    MessageBox.Show("ERRO AO CADASTRAR O PRODUTO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NovoProduto();
                    return;
                }

                MessageBox.Show("PRODUTO CADASTRADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NovoProduto()
        {
            txtNomeProduto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtVL_Pago.Text = string.Empty;
            txtVL_Venda.Text = string.Empty;
            txtCodigoRapido.Text = string.Empty;
            txtPontos.Text = string.Empty;
            cboSessao.SelectedItem = null;
        }

        #region Transformando campos texto em numeric
        private void txtVL_Pago_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (!regex.IsMatch(txtVL_Pago.Text))
            {
                txtVL_Pago.Text = string.Empty;
            }
        }

        private void txtVL_Venda_TextChanged(object sender, EventArgs e)
        {
            if (!regex.IsMatch(txtVL_Venda.Text))
            {
                txtVL_Venda.Text = string.Empty;
            }
        }

        private void txtCodigoRapido_TextChanged(object sender, EventArgs e)
        {
            if (!regex.IsMatch(txtCodigoRapido.Text))
            {
                txtCodigoRapido.Text = string.Empty;
            }
        }

        private void txtPontos_TextChanged(object sender, EventArgs e)
        {
            if (!regex.IsMatch(txtPontos.Text))
            {
                txtPontos.Text = string.Empty;
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!regex.IsMatch(txtQuantidade.Text))
            {
                txtQuantidade.Text = string.Empty;
            }
        }
        #endregion
    }
}
