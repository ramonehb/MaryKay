﻿using DAL;
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
            if (!new int[] { 1, 2 }.Contains(Session.ID_TipoUsuario))
            {
                tsbNovo.Visible = false;
                tsbAlterar.Visible = false;
                tsbExcluir.Visible = false;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.maryKayDataSet.Cliente);

        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroCliente cadastroCliente = new CadastroCliente(0);
            cadastroCliente.Closed += (s, args) => this.Close();
            cadastroCliente.ShowDialog();
        }

        private void tsbAlterar_Click(object sender, EventArgs e)
        {
            var idCliente = (int)dgvClientes.CurrentRow.Cells["iDClienteDataGridViewTextBoxColumn"].Value;

            this.Hide();
            CadastroCliente cadastroCliente = new CadastroCliente(idCliente);
            cadastroCliente.Closed += (s, args) => this.Close();
            cadastroCliente.ShowDialog();
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            var idCliente = (int) dgvClientes.CurrentRow.Cells["iDClienteDataGridViewTextBoxColumn"].Value;
            var nomeCliente = dgvClientes.CurrentRow.Cells["nomeDataGridViewTextBoxColumn"].Value.ToString();
            var msg = "TEM CERTEZA QUE DESEJA EXCLUIR O " + nomeCliente + " ?";

            if (idCliente != 0)
            {
                var pergunta = MessageBox.Show(msg , "MARY MAY", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (pergunta == DialogResult.Yes)
                {
                    var clienteDAL = new ClienteDAL();
                    if (!clienteDAL.DeletarCliente(idCliente))
                    {
                        MessageBox.Show("ERRO AO DELETAR O CLIENTE", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("CLIENTE DELETADO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    var voltar = new Clientes();
                    voltar.Closed += (s, args) => this.Close();
                    voltar.ShowDialog();
                }
            }
        }

        private void tsbVoltar_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicial();
            telaInicial.ShowDialog();
            this.Close();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using(var db = new BaseDataContext())
                {
                    var clienteFiltro = db.Clientes.Where(cf => cf.Nome.Contains(txtBuscaCliente.Text));
                    dgvClientes.DataSource = clienteFiltro;
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
            var voltar = new TelaInicial();
            voltar.Closed += (s, args) => this.Close();
            voltar.ShowDialog();
        }
    }
}
