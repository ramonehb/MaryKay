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
    public partial class PedidoNovo : Form
    {
        DataTable carinho = new DataTable();
        public int idPedido = 0;
        public ItemPedidoDAL itemPedido = new ItemPedidoDAL();
        public List<ItemPedidoDAL> Items = new List<ItemPedidoDAL>();


        public PedidoNovo()
        {
            InitializeComponent();
        }
        public PedidoNovo(int idPedido)
        {
            InitializeComponent();
            txtIdPedido.Text = idPedido.ToString();
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            //var pedido = new Pedido();
            //pedido.ShowDialog();
            //this.Close();
            Application.Exit();
        }

        private void PedidoNovo_Load(object sender, EventArgs e)
        {
            this.produtoTableAdapter.Fill(this.comboBoxProduto.Produto);
            this.clienteTableAdapter.Fill(this.comboBoxClientes.Cliente);
            carinho.Columns.Add("Nome");
            carinho.Columns.Add("Quantidade");
            carinho.Columns.Add("Preço Unitario");
            carinho.Columns.Add("SubTotal");
        }

        private void tsbRemoverCliente_Click_1(object sender, EventArgs e)
        {
            lCliente.Visible = true;
            cboCliente.Visible = true;
            tsbAdicionarCliente.Visible = true;
            tsAdicionarCliente.Visible = true;
            tssAdicionarCliente.Visible = true;
            lClienteSelecionado.Text = string.Empty;

            lProduto.Visible = false;
            cbProdutos.Visible = false;
            lQuantidade.Visible = false;
            nudQuantidade.Visible = false;
            tsAdicionarCliente.Visible = false;
            tsbExcluirCliente.Visible = false;
        }

        private void tsbAdicionarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                lCliente.Visible = false;
                cboCliente.Visible = false;
                tssAdicionarCliente.Visible = false;

                using (var db = new BaseDataContext())
                {
                    var cliente = db.Clientes.SingleOrDefault(c => c.ID_Cliente == (int)cboCliente.SelectedValue);
                    lClienteSelecionado.Text = $"CLIENTE: {cliente.Nome}";
                }

                lProduto.Visible = true;
                cbProdutos.Visible = true;
                lQuantidade.Visible = true;
                nudQuantidade.Visible = true;
                tsAdicionarCliente.Visible = true;
                tsbExcluirCliente.Visible = true;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        private void tsbAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BaseDataContext())
                {
                    var produto = db.Produtos.SingleOrDefault(p => p.ID_Produto == (int)cbProdutos.SelectedValue);
                    var cliente = db.Clientes.SingleOrDefault(c => c.ID_Cliente == (int)cboCliente.SelectedValue);

                    var quantidade = int.Parse(nudQuantidade.Text);

                    itemPedido = new ItemPedidoDAL(produto, quantidade);

                    //if (dgvCarinho.RowCount > 0)
                    //{
                    //    foreach (var item in itemPedido.Items)
                    //    {
                    //        if (item.Produto.ID_Produto == produto.ID_Produto)
                    //        {
                    //            MessageBox.Show("Dois registros desse");

                    //        }
                    //    }
                    //}

                    Items.Add(itemPedido);

                    //var item = new ItemPedido();
                    //item.ID_Produto = produto.ID_Produto;
                    //item.ID_Pedido = 1;
                    //item.Quantidade = quantidade;
                    //item.SubTotal = (decimal) itemPedido.SubTotal();

                    //itemPedido.AdicionarItem(item);


                    carinho.Rows.Add(produto.Nome, quantidade, produto.VL_Venda, itemPedido.SubTotal().ToString("N2"));
                    dgvCarinho.DataSource = carinho;
                    ConfiguraGridViewCarinho();
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        public void ConfiguraGridViewCarinho()
        {
            DataGridViewColumn colunaNome = dgvCarinho.Columns[0];
            DataGridViewColumn colunaQuantidade = dgvCarinho.Columns[1];
            DataGridViewColumn colunaPreco = dgvCarinho.Columns[2];
            DataGridViewColumn colunaSubTotal = dgvCarinho.Columns[3];

            colunaNome.Width = 400;
            colunaQuantidade.Width = 400;
            colunaPreco.Width = 400;
            colunaSubTotal.Width = 305;
            colunaNome.ReadOnly = true;
            colunaQuantidade.ReadOnly = true;
            colunaPreco.ReadOnly = true;
            colunaSubTotal.ReadOnly = true;

            lAvisoCarrinho.Visible = false;
            tsbExcluirItem.Visible = true;
            btnFinalizar.Visible = true;
            nudQuantidade.Text = "1";

        }

        private void tsbPedidoNovo_Click(object sender, EventArgs e)
        {
            var pedido = new PedidoNovo();
            pedido.ShowDialog();
        }

        private void tsbExcluirItem_Click(object sender, EventArgs e)
        {
            if (dgvCarinho.SelectedRows.Count > 0)
            {
                
            }
            else
            {
                MessageBox.Show("Selecione o item do carinho para remover");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            var pedido = new PedidoDAL();
            if (string.IsNullOrEmpty(lClienteSelecionado.Text))
            {
                MessageBox.Show("SELECIONE O CLIENTE PARA FINALIZAR A VENDA", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dgvCarinho.Rows.Count <= 0)
            {
                MessageBox.Show("O CARINHO ESTÁ VAZIO", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            double sum = 0;
            foreach (var item in Items)
            {
                sum += item.SubTotal();
            }

            var formaPagamento = new FormaPagamento(sum);
            formaPagamento.ShowDialog();
            
        }
    }
}
