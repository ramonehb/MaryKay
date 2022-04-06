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
        public ItemPedidoDAL itemPedido = new ItemPedidoDAL();
        public List<ItemPedidoDAL> Items = new List<ItemPedidoDAL>();


        public PedidoNovo()
        {
            InitializeComponent();
        }

        private void tsbFechar_Click(object sender, EventArgs e)
        {
            var pedido = new Pedidos();
            pedido.ShowDialog();
            this.Close();
        }

        private void CarinhoNovo()
        {
            carinho.Columns.Add("Nome");
            carinho.Columns.Add("Quantidade");
            carinho.Columns.Add("Preço Unitario");
            carinho.Columns.Add("SubTotal");
        }

        private void PedidoNovo_Load(object sender, EventArgs e)
        {
            this.produtoTableAdapter.Fill(this.comboBoxProduto.Produto);
            this.clienteTableAdapter.Fill(this.comboBoxClientes.Cliente);
            CarinhoNovo();
        }

        private void tsbRemoverCliente_Click_1(object sender, EventArgs e)
        {
            try
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

                using (var db = new BaseDataContext())
                {
                    var pedido = db.Pedidos.SingleOrDefault(p => p.ID_Pedido == int.Parse(txtIdPedido.Text));

                    if (pedido.ItemPedidos.Count > 0)
                    {
                        db.ItemPedidos.DeleteAllOnSubmit(pedido.ItemPedidos);
                        db.SubmitChanges();
                    }
                        
                    db.Pedidos.DeleteOnSubmit(pedido);
                    db.SubmitChanges();
                    txtIdPedido.Text = string.Empty;
                    
                    dgvCarinho.DataSource = null;
                    lAvisoCarrinho.Visible = true;

                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        private void tsbAdicionarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                lCliente.Visible = false;
                cboCliente.Visible = false;
                tssAdicionarCliente.Visible = false;
                lProduto.Visible = true;
                cbProdutos.Visible = true;
                lQuantidade.Visible = true;
                nudQuantidade.Visible = true;
                tsAdicionarCliente.Visible = true;
                tsbExcluirCliente.Visible = true;

                using (var db = new BaseDataContext())
                {
                    var cliente = db.Clientes.SingleOrDefault(c => c.ID_Cliente == (int)cboCliente.SelectedValue);
                    lClienteSelecionado.Text = $"CLIENTE: {cliente.Nome}";

                    var pedido = new Pedido();
                    pedido.ID_Cliente = cliente.ID_Cliente;
                    pedido.ID_PedidoStatus = 1;
                    pedido.ID_Usuario = 1;
                    db.Pedidos.InsertOnSubmit(pedido);
                    db.SubmitChanges();
                    txtIdPedido.Text = pedido.ID_Pedido.ToString();
                }
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

                    var novoItem = new ItemPedido();
                    novoItem.ID_Pedido = int.Parse(txtIdPedido.Text); 
                    novoItem.ID_Produto = produto.ID_Produto;
                    novoItem.Quantidade = quantidade;
                    novoItem.SubTotal = (decimal) itemPedido.SubTotal();
                    db.ItemPedidos.InsertOnSubmit(novoItem);

                    db.SubmitChanges();

                    
                    Items.Add(itemPedido);

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
            try
            {
                using (var db = new BaseDataContext())
                {
                    if (dgvCarinho.SelectedRows.Count > 0)
                    {
                        if (dgvCarinho.Rows.Count == 1)
                        {
                            tsbExcluirItem.Visible = false;
                            lAvisoCarrinho.Visible = true;
                        }
                        //Verificar a quetão do data
                        //var idCliente = (int)dgvCarinho.CurrentRow.Cells["iDClienteDataGridViewTextBoxColumn"].Value;
                        //var idItemPedido = (int)dgvCarinho.CurrentRow.Cells["iDClienteDataGridViewTextBoxColumn"].Value;
                        //var itemPedido = db.ItemPedidos.SingleOrDefault(i => i.ID_ItemPedido == idItemPedido && i.ID_Pedido == int.Parse(txtIdPedido.Text));
                        //db.ItemPedidos.DeleteOnSubmit(itemPedido);
                        //db.SubmitChanges();

                        foreach (DataGridViewRow item in dgvCarinho.SelectedRows)
                        {
                            dgvCarinho.Rows.RemoveAt(item.Index);
                        }
                    }
                    else
                    {
                        MessageBox.Show("SELECIONE O ITEM PARA REMOVER", "MARY KAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
            

           
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
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

                using (var db = new BaseDataContext())
                {
                    var pedido = db.Pedidos.SingleOrDefault(p => p.ID_Pedido == int.Parse(txtIdPedido.Text));
                    pedido.ID_PedidoStatus = 2;

                    decimal valorTotal = 0;
                    foreach (var item in Items)
                    {
                        valorTotal += (decimal) item.SubTotal();
                    }
                    pedido.VL_Total = valorTotal;
                    db.SubmitChanges();

                    var formaPagamento = new FormaPagamento(pedido.ID_Pedido);
                    formaPagamento.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
}
