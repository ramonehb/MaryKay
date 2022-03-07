
namespace MaryKay
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProdutosVenda = new MaryKay.DataSetProdutosVenda();
            this.produtoTableAdapter = new MaryKay.DataSetProdutosVendaTableAdapters.ProdutoTableAdapter();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.dgvCarrinhoVenda = new System.Windows.Forms.DataGridView();
            this.colunaIDProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProdutosVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(82, 806);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 48);
            this.label5.TabIndex = 41;
            this.label5.Text = "PESQUISA PRODUTO";
            // 
            // cboProduto
            // 
            this.cboProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource, "ID_Produto", true));
            this.cboProduto.DataSource = this.produtoBindingSource;
            this.cboProduto.DisplayMember = "Nome";
            this.cboProduto.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(604, 806);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(975, 50);
            this.cboProduto.TabIndex = 40;
            this.cboProduto.ValueMember = "ID_Produto";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dataSetProdutosVenda;
            // 
            // dataSetProdutosVenda
            // 
            this.dataSetProdutosVenda.DataSetName = "DataSetProdutosVenda";
            this.dataSetProdutosVenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.ForestGreen;
            this.btAdicionar.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.Color.White;
            this.btAdicionar.Location = new System.Drawing.Point(1643, 792);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(255, 77);
            this.btAdicionar.TabIndex = 82;
            this.btAdicionar.Text = "ADICIONAR";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // dgvCarrinhoVenda
            // 
            this.dgvCarrinhoVenda.AllowUserToAddRows = false;
            this.dgvCarrinhoVenda.AllowUserToDeleteRows = false;
            this.dgvCarrinhoVenda.AllowUserToResizeColumns = false;
            this.dgvCarrinhoVenda.AllowUserToResizeRows = false;
            this.dgvCarrinhoVenda.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvCarrinhoVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrinhoVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarrinhoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinhoVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaIDProduto,
            this.colunaNomeProduto,
            this.Quantidade,
            this.ColunaValorUnitario,
            this.ValorTotal});
            this.dgvCarrinhoVenda.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarrinhoVenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCarrinhoVenda.GridColor = System.Drawing.Color.Black;
            this.dgvCarrinhoVenda.Location = new System.Drawing.Point(51, 62);
            this.dgvCarrinhoVenda.MultiSelect = false;
            this.dgvCarrinhoVenda.Name = "dgvCarrinhoVenda";
            this.dgvCarrinhoVenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarrinhoVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarrinhoVenda.RowHeadersVisible = false;
            this.dgvCarrinhoVenda.RowHeadersWidth = 51;
            this.dgvCarrinhoVenda.RowTemplate.Height = 30;
            this.dgvCarrinhoVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrinhoVenda.Size = new System.Drawing.Size(1825, 684);
            this.dgvCarrinhoVenda.TabIndex = 83;
            // 
            // colunaIDProduto
            // 
            this.colunaIDProduto.HeaderText = "ID_Produto";
            this.colunaIDProduto.MinimumWidth = 6;
            this.colunaIDProduto.Name = "colunaIDProduto";
            this.colunaIDProduto.ReadOnly = true;
            this.colunaIDProduto.Visible = false;
            this.colunaIDProduto.Width = 125;
            // 
            // colunaNomeProduto
            // 
            this.colunaNomeProduto.HeaderText = "NomeProduto";
            this.colunaNomeProduto.MinimumWidth = 6;
            this.colunaNomeProduto.Name = "colunaNomeProduto";
            this.colunaNomeProduto.ReadOnly = true;
            this.colunaNomeProduto.Width = 125;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 125;
            // 
            // ColunaValorUnitario
            // 
            this.ColunaValorUnitario.HeaderText = "ValorUnitario";
            this.ColunaValorUnitario.MinimumWidth = 6;
            this.ColunaValorUnitario.Name = "ColunaValorUnitario";
            this.ColunaValorUnitario.ReadOnly = true;
            this.ColunaValorUnitario.Width = 125;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.MinimumWidth = 6;
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 125;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1924, 1006);
            this.Controls.Add(this.dgvCarrinhoVenda);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboProduto);
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProdutosVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinhoVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboProduto;
        private DataSetProdutosVenda dataSetProdutosVenda;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DataSetProdutosVendaTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.DataGridView dgvCarrinhoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaIDProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
    }
}