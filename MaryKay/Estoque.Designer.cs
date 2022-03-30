
namespace MaryKay
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAjustarEstoque = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.nm = new System.Windows.Forms.Label();
            this.vwEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewEstoque = new MaryKay.ViewEstoque();
            this.vw_EstoqueTableAdapter = new MaryKay.ViewEstoqueTableAdapters.vw_EstoqueTableAdapter();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvViewEstoque = new System.Windows.Forms.DataGridView();
            this.iDProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDECOMPRADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDEVENDADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUCRODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEstoque)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tsbAjustarEstoque,
            this.toolStripSeparator3,
            this.toolStripSeparator1,
            this.toolStripSeparator4});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1924, 52);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbAjustarEstoque
            // 
            this.tsbAjustarEstoque.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.tsbAjustarEstoque.ForeColor = System.Drawing.Color.Black;
            this.tsbAjustarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("tsbAjustarEstoque.Image")));
            this.tsbAjustarEstoque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAjustarEstoque.Name = "tsbAjustarEstoque";
            this.tsbAjustarEstoque.Size = new System.Drawing.Size(271, 49);
            this.tsbAjustarEstoque.Text = "AJUSTAR ESTOQUE";
            this.tsbAjustarEstoque.Click += new System.EventHandler(this.tsbAjustarEstoque_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip3.BackgroundImage")));
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator9,
            this.toolStripSeparator10,
            this.toolStripSeparator11,
            this.toolStripSeparator12});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip3.Location = new System.Drawing.Point(0, 52);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1924, 23);
            this.toolStrip3.TabIndex = 85;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 23);
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.BackColor = System.Drawing.Color.Transparent;
            this.nm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nm.Font = new System.Drawing.Font("Arial", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm.ForeColor = System.Drawing.Color.Black;
            this.nm.Location = new System.Drawing.Point(915, 69);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(242, 68);
            this.nm.TabIndex = 86;
            this.nm.Text = "Estoque";
            // 
            // vwEstoqueBindingSource
            // 
            this.vwEstoqueBindingSource.DataMember = "vw_Estoque";
            this.vwEstoqueBindingSource.DataSource = this.viewEstoque;
            // 
            // viewEstoque
            // 
            this.viewEstoque.DataSetName = "ViewEstoque";
            this.viewEstoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_EstoqueTableAdapter
            // 
            this.vw_EstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip2.BackgroundImage")));
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.tsbFechar,
            this.toolStripSeparator6,
            this.toolStripSeparator7,
            this.toolStripSeparator8});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip2.Location = new System.Drawing.Point(1880, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(154, 52);
            this.toolStrip2.TabIndex = 88;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbFechar
            // 
            this.tsbFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbFechar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.tsbFechar.ForeColor = System.Drawing.Color.Black;
            this.tsbFechar.Image = ((System.Drawing.Image)(resources.GetObject("tsbFechar.Image")));
            this.tsbFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFechar.Name = "tsbFechar";
            this.tsbFechar.Size = new System.Drawing.Size(129, 49);
            this.tsbFechar.Text = "FECHAR";
            this.tsbFechar.Click += new System.EventHandler(this.tsbFechar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
            // 
            // dgvViewEstoque
            // 
            this.dgvViewEstoque.AllowUserToAddRows = false;
            this.dgvViewEstoque.AllowUserToDeleteRows = false;
            this.dgvViewEstoque.AllowUserToResizeColumns = false;
            this.dgvViewEstoque.AllowUserToResizeRows = false;
            this.dgvViewEstoque.AutoGenerateColumns = false;
            this.dgvViewEstoque.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvViewEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProdutoDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn1,
            this.cATEGORIADataGridViewTextBoxColumn1,
            this.qUANTIDADEDataGridViewTextBoxColumn1,
            this.vALORDECOMPRADataGridViewTextBoxColumn1,
            this.vALORDEVENDADataGridViewTextBoxColumn1,
            this.lUCRODataGridViewTextBoxColumn1});
            this.dgvViewEstoque.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvViewEstoque.DataSource = this.vwEstoqueBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewEstoque.GridColor = System.Drawing.Color.Black;
            this.dgvViewEstoque.Location = new System.Drawing.Point(12, 176);
            this.dgvViewEstoque.MultiSelect = false;
            this.dgvViewEstoque.Name = "dgvViewEstoque";
            this.dgvViewEstoque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViewEstoque.RowHeadersVisible = false;
            this.dgvViewEstoque.RowHeadersWidth = 51;
            this.dgvViewEstoque.RowTemplate.Height = 30;
            this.dgvViewEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewEstoque.Size = new System.Drawing.Size(2010, 792);
            this.dgvViewEstoque.TabIndex = 89;
            // 
            // iDProdutoDataGridViewTextBoxColumn
            // 
            this.iDProdutoDataGridViewTextBoxColumn.DataPropertyName = "ID_Produto";
            this.iDProdutoDataGridViewTextBoxColumn.HeaderText = "ID_Produto";
            this.iDProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProdutoDataGridViewTextBoxColumn.Name = "iDProdutoDataGridViewTextBoxColumn";
            this.iDProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProdutoDataGridViewTextBoxColumn.Visible = false;
            this.iDProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nOMEDataGridViewTextBoxColumn1
            // 
            this.nOMEDataGridViewTextBoxColumn1.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn1.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nOMEDataGridViewTextBoxColumn1.Name = "nOMEDataGridViewTextBoxColumn1";
            this.nOMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nOMEDataGridViewTextBoxColumn1.Width = 400;
            // 
            // cATEGORIADataGridViewTextBoxColumn1
            // 
            this.cATEGORIADataGridViewTextBoxColumn1.DataPropertyName = "CATEGORIA";
            this.cATEGORIADataGridViewTextBoxColumn1.HeaderText = "CATEGORIA";
            this.cATEGORIADataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cATEGORIADataGridViewTextBoxColumn1.Name = "cATEGORIADataGridViewTextBoxColumn1";
            this.cATEGORIADataGridViewTextBoxColumn1.ReadOnly = true;
            this.cATEGORIADataGridViewTextBoxColumn1.Width = 350;
            // 
            // qUANTIDADEDataGridViewTextBoxColumn1
            // 
            this.qUANTIDADEDataGridViewTextBoxColumn1.DataPropertyName = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn1.HeaderText = "QUANTIDADE";
            this.qUANTIDADEDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.qUANTIDADEDataGridViewTextBoxColumn1.Name = "qUANTIDADEDataGridViewTextBoxColumn1";
            this.qUANTIDADEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.qUANTIDADEDataGridViewTextBoxColumn1.Width = 150;
            // 
            // vALORDECOMPRADataGridViewTextBoxColumn1
            // 
            this.vALORDECOMPRADataGridViewTextBoxColumn1.DataPropertyName = "VALOR DE COMPRA";
            this.vALORDECOMPRADataGridViewTextBoxColumn1.HeaderText = "VALOR DE COMPRA";
            this.vALORDECOMPRADataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.vALORDECOMPRADataGridViewTextBoxColumn1.Name = "vALORDECOMPRADataGridViewTextBoxColumn1";
            this.vALORDECOMPRADataGridViewTextBoxColumn1.ReadOnly = true;
            this.vALORDECOMPRADataGridViewTextBoxColumn1.Width = 250;
            // 
            // vALORDEVENDADataGridViewTextBoxColumn1
            // 
            this.vALORDEVENDADataGridViewTextBoxColumn1.DataPropertyName = "VALOR DE VENDA";
            this.vALORDEVENDADataGridViewTextBoxColumn1.HeaderText = "VALOR DE VENDA";
            this.vALORDEVENDADataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.vALORDEVENDADataGridViewTextBoxColumn1.Name = "vALORDEVENDADataGridViewTextBoxColumn1";
            this.vALORDEVENDADataGridViewTextBoxColumn1.ReadOnly = true;
            this.vALORDEVENDADataGridViewTextBoxColumn1.Width = 250;
            // 
            // lUCRODataGridViewTextBoxColumn1
            // 
            this.lUCRODataGridViewTextBoxColumn1.DataPropertyName = "LUCRO";
            this.lUCRODataGridViewTextBoxColumn1.HeaderText = "LUCRO";
            this.lUCRODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lUCRODataGridViewTextBoxColumn1.Name = "lUCRODataGridViewTextBoxColumn1";
            this.lUCRODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1924, 980);
            this.ControlBox = false;
            this.Controls.Add(this.dgvViewEstoque);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewEstoque)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAjustarEstoque;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.Label nm;
        private ViewEstoque viewEstoque;
        private System.Windows.Forms.BindingSource vwEstoqueBindingSource;
        private ViewEstoqueTableAdapters.vw_EstoqueTableAdapter vw_EstoqueTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.DataGridView dgvViewEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORIADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTIDADEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDECOMPRADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDEVENDADataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUCRODataGridViewTextBoxColumn1;
    }
}