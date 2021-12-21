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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'maryKayDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.maryKayDataSet.Cliente);

        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente(0);
            cadastroCliente.ShowDialog();
            this.Close();
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            var idCliente = dgvClientes.CurrentRow.Cells["iDClienteDataGridViewTextBoxColumn"].Value;
            CadastroCliente cadastroCliente = new CadastroCliente((int)idCliente);
            cadastroCliente.ShowDialog();
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            var idCliente = dgvClientes.CurrentRow.Cells["iDClienteDataGridViewTextBoxColumn"].Value;
            if ((int) idCliente != 0)
            {
                var pergunta = MessageBox.Show("TEM CERTEZA DA EXCLUSÂO ? ", "MARY MAY", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (pergunta == DialogResult.Yes)
                {
                    ClienteDAL clienteDAL = new ClienteDAL();
                    if (!clienteDAL.DeletarCliente((int) idCliente))
                    {
                        MessageBox.Show("ERRO AO DELETAR O CLIENTE", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("CLIENTE DELETADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clientes voltar = new Clientes();
                    voltar.ShowDialog();
                }
            }
        }

        private void tsbVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.ShowDialog();
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using(var db = new BaseDataContext())
                {
                    var clienteFiltro = db.Clientes.Where(cf => cf.Nome.Contains(txtNome.Text));
                    dgvClientes.DataSource = clienteFiltro;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
