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
    public partial class CadastroEstimativa : Form
    {
        public CadastroEstimativa()
        {
            InitializeComponent();
            LMesReferente.Text = DateTime.Today.ToString();
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            var pedido = new Pedidos();
            pedido.Closed += (s, args) => this.Close();
            pedido.ShowDialog();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var newEstimativa = new Estimativa();
                    newEstimativa.VL_Estimativa = decimal.Parse(nudVL_Estimativa.Text);
                    newEstimativa.DT_Mes = DateTime.Now;
                    db.Estimativas.InsertOnSubmit(newEstimativa);
                    db.SubmitChanges();

                    var pedido = new Pedidos();
                    pedido.Closed += (s, args) => this.Close();
                    pedido.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
}
