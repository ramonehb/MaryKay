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
        public CadastroProduto(int idProduto)
        {
            InitializeComponent();
            nudVL_Pago.Controls.RemoveAt(0);
            nudVL_Venda.Controls.RemoveAt(0);
            nudPontos.Controls.RemoveAt(0);
            nudCodigoRapido.Controls.RemoveAt(0);
            btFinalizar.Text = idProduto == 0 ? "FINALIZAR" : "ATUALIZAR";
            
            if (idProduto != 0)
            {
                txtIdProduto.Text = idProduto.ToString();
                CarregaProduto(idProduto);
            }
            else
            {
                NovoProduto();
            }
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            this.tipo_ProdutoTableAdapter.Fill(this.maryKayDataSet1.Tipo_Produto);
        }

        private bool ValidaProduto()
        {
            var erro = 0;
            var novo = string.IsNullOrEmpty(txtIdProduto.Text) ? true : false;

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

            if (string.IsNullOrEmpty(nudQuantidade.Text) && novo)
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
                    if (codigoExistente && novo)
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

        private void NovoProduto()
        {
            labelQtd.Visible = true;
            nudQuantidade.Visible = true;

            txtIdProduto.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            nudQuantidade.Text = string.Empty;
            nudVL_Pago.Text = string.Empty;
            nudVL_Venda.Text = string.Empty;
            nudCodigoRapido.Text = string.Empty;
            nudPontos.Text = string.Empty;
            cboSessao.SelectedItem = null;
        }

        private void CarregaProduto(int idProduto)
        {
            try
            {
                labelQtd.Visible = false;
                nudQuantidade.Visible = false;

                using (var db = new BaseDataContext())
                {
                    var produto = db.Produtos.Single(p => p.ID_Produto == idProduto);
                    txtIdProduto.Text = produto.ID_Produto.ToString();
                    txtNomeProduto.Text = produto.Nome;
                    nudVL_Pago.Text = produto.VL_Pago.ToString();
                    nudVL_Venda.Text = produto.VL_Venda.ToString();
                    nudCodigoRapido.Text = produto.Codigo.ToString();
                    nudPontos.Text = produto.Pontos.ToString();
                    cboSessao.SelectedItem = produto.Sessao.ToString();
                }
            }
            catch (Exception erro)
            {
                var msg = erro.Message;
            }
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var voltar = new Produtos();
            voltar.Closed += (s, args) => this.Close();
            voltar.ShowDialog();
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidaProduto())
            {
                var novoProduto = string.IsNullOrEmpty(txtIdProduto.Text);
                var produto = new Produto();

                if (!novoProduto)
                {
                    produto.ID_Produto = int.Parse(txtIdProduto.Text);
                }

                produto.Nome = txtNomeProduto.Text;
                produto.ID_TipoProduto = (int)cboTipoProduto.SelectedValue;
                produto.Codigo = int.Parse(nudCodigoRapido.Text);
                produto.Pontos = int.Parse(nudPontos.Text);
                produto.VL_Pago = decimal.Parse(nudVL_Pago.Text);
                produto.VL_Venda = decimal.Parse(nudVL_Venda.Text);
                produto.Sessao = int.Parse((string)cboSessao.SelectedItem);
                produto.ID_Usuario = 1;

                var produtoDAL = new ProdutoDAL();

                if (novoProduto)
                {
                    if (!produtoDAL.CadastrarProduto(produto, int.Parse(nudQuantidade.Text)))
                    {
                        MessageBox.Show("ERRO AO CADASTRAR O PRODUTO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("PRODUTO CADASTRADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!produtoDAL.AlterarProduto(produto))
                    {
                        MessageBox.Show("ERRO AO ATUALIZAR O PRODUTO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("PRODUTO ATUALIZADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Hide();
                var voltar = new Produtos();
                voltar.Closed += (s, args) => this.Close();
                voltar.ShowDialog();
            }
        }
    }
}
