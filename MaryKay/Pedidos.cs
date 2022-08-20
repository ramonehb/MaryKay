using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaryKay
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            try
            {
                using (var db = new BaseDataContext())
                {
                    var estimativa = db.Estimativas.SingleOrDefault(e => e.DT_Mes.Value.Month == DateTime.Now.Month);
                    if (estimativa == null)
                        return;

                    decimal falta = (decimal)(estimativa.VL_Estimativa - estimativa.VL_TotalVendido);
                    lEstimativa.Text = estimativa.VL_Estimativa.ToString();
                    lTotal.Text = estimativa.VL_TotalVendido.ToString();
                    lFalta.Text = falta < 0 ? "Meta batida." : falta.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            if (Session.ID_TipoUsuario == 1)
            {
                this.Hide();
                var pedido = new PedidoNovo();
                pedido.Closed += (s, args) => this.Close();
                pedido.ShowDialog();
            }
            else
            {
                MessageBox.Show("USUÁRIO NÃO TEM PERMISSÃO.", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicial();
            telaInicial.Closed += (s, args) => this.Close();
            telaInicial.ShowDialog();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            this.vw_VisaoVendasTableAdapter.Fill(this.viewVendas.vw_VisaoVendas);

        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            var idPedido = (int)dgvVendas.CurrentRow.Cells["iDDataGridViewTextBoxColumn"].Value;
            try
            {
                using (var db = new BaseDataContext())
                {
                    var pedido = db.Pedidos.Single(p => p.ID_Pedido == idPedido);
                    pedido.ID_PedidoStatus = 4;
                    db.SubmitChanges();
                    MessageBox.Show("VENDA CANCELADA COM SUCESSO.", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var refesh = new Pedidos();
                    refesh.Closed += (s, args) => this.Close();
                    refesh.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONTATE O ADMINISTRADOR.", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbFechar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var voltar = new TelaInicial();
            voltar.Closed += (s, args) => this.Close();
            voltar.ShowDialog();
        }

        private void tsbAdicionarEstimativa_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cadastro = new CadastroEstimativa();
            cadastro.Closed += (s, args) => this.Close();
            cadastro.ShowDialog();
        }
    }
}
