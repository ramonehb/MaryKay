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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void tsbVoltar_Click(object sender, EventArgs e)
        {
            var voltar = new TelaInicial();
            voltar.ShowDialog();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            this.vw_EstoqueTableAdapter.Fill(this.dataSetViewEstoque.vw_Estoque);
        }
    }
}
