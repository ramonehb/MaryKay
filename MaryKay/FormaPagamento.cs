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
    public partial class FormaPagamento : Form
    {
        public FormaPagamento()
        {
            InitializeComponent();
        }
        public FormaPagamento(int idPedido)
        {
            InitializeComponent();

            try
            {
                using (var db = new BaseDataContext())
                {
                    var pedido = db.Pedidos.SingleOrDefault(p => p.ID_Pedido == idPedido);
                    nudTotalAPagar.Text = pedido.VL_Total.ToString();
                    txtIdPedido.Text = pedido.ID_Pedido.ToString();
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
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
            else if (totalRecebido < total)
            {
                lTrocoFalta.Text = "FALTA";
                lTrocoFalta.ForeColor = Color.Red;
                troco = -troco;
                nudTroco.Text = troco.ToString("N2");
                return;
            }
            else
            {
                lTrocoFalta.Text = "TROCO";
                lTrocoFalta.ForeColor = Color.Black;
                nudTroco.Text = "0,00";
            }
            cboFormaPagamento.Focus();
        }

        private void FormaPagamento_Load(object sender, EventArgs e)
        {
            this.formaPagamentoTableAdapter.Fill(this.comboBoxForma.FormaPagamento);

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                var total = double.Parse(nudTotalAPagar.Text);
                var totalRecebido = double.Parse(nudTotalRecebido.Text);
                if (totalRecebido < total)
                {
                    MessageBox.Show("VALOR RECEBIDO MENOR QUE O VALOR TOTAL", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new BaseDataContext())
                {
                    var pedido = db.Pedidos.SingleOrDefault(p => p.ID_Pedido == int.Parse(txtIdPedido.Text));
                    pedido.ID_PedidoStatus = 3;
                    pedido.ID_FormaPagamento = (int)cboFormaPagamento.SelectedValue;
                    pedido.DT_Venda = DateTime.Now;
                    db.SubmitChanges();

                    MessageBox.Show("VENDA FINALIZADA COM SUCESSO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var voltar = new Pedidos();
                    voltar.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                throw;
            }
        }
    }
}
