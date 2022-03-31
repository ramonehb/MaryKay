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
    public partial class FormaPagamento : Form
    {
        public FormaPagamento()
        {
            InitializeComponent();
        }
        public FormaPagamento(double total)
        {
            InitializeComponent();
            nudTotalAPagar.Text = total.ToString("N2");
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            var pedido = new PedidoNovo();
            pedido.ShowDialog();
            this.Close();
        }

        private void nudTotalRecebido_ValueChanged(object sender, EventArgs e)
        {
            var total = double.Parse(nudTotalAPagar.Text);
            var totalRecebido = double.Parse(nudTotalRecebido.Text);
            var troco = (double)totalRecebido - total ;

            if (totalRecebido > total)
            {
                lTrocoFalta.Text = "TROCO";
                lTrocoFalta.ForeColor = Color.Green;
                nudTroco.Text = troco.ToString("N2");
            }
            else
            {
                lTrocoFalta.Text = "FALTA";
                lTrocoFalta.ForeColor = Color.Red;
                troco = -troco;
                nudTroco.Text = troco.ToString("N2");
                return;
            }
            cboFormaPagamento.Focus();
        }

        private void FormaPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'comboBoxForma.FormaPagamento'. Você pode movê-la ou removê-la conforme necessário.
            this.formaPagamentoTableAdapter.Fill(this.comboBoxForma.FormaPagamento);

        }
    }
}
