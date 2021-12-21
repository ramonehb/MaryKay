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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void bFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            if (cboSessao.SelectedValue == null)
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

            return erro == 0;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ValidaProduto();
        }
    }
}
