﻿
namespace MaryKay
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.vwProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maryKayDataSet3 = new MaryKay.MaryKayDataSet3();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nm = new System.Windows.Forms.Label();
            this.vw_ProdutosTableAdapter = new MaryKay.MaryKayDataSet3TableAdapters.vw_ProdutosTableAdapter();
            this.NomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIADOPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cÓDIGORÁPIDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pONTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDECOMPRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDEVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUCRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sESSÃODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maryKayDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.toolStripSeparator2,
            this.tsbAtualizar,
            this.toolStripSeparator3,
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.tsbVoltar,
            this.toolStripSeparator4});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(2034, 52);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNovo.ForeColor = System.Drawing.Color.Black;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(233, 49);
            this.tsbNovo.Text = "NOVO PRODUTO";
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbAtualizar
            // 
            this.tsbAtualizar.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.tsbAtualizar.ForeColor = System.Drawing.Color.Black;
            this.tsbAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAtualizar.Image")));
            this.tsbAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtualizar.Name = "tsbAtualizar";
            this.tsbAtualizar.Size = new System.Drawing.Size(294, 49);
            this.tsbAtualizar.Text = "ATUALIZAR PRODUTO";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.tsbExcluir.ForeColor = System.Drawing.Color.Black;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(266, 49);
            this.tsbExcluir.Text = "EXCLUIR PRODUTO";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbVoltar
            // 
            this.tsbVoltar.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.tsbVoltar.ForeColor = System.Drawing.Color.Black;
            this.tsbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("tsbVoltar.Image")));
            this.tsbVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVoltar.Name = "tsbVoltar";
            this.tsbVoltar.Size = new System.Drawing.Size(357, 49);
            this.tsbVoltar.Text = "VOLTAR PARA TELA INICIAL";
            this.tsbVoltar.Click += new System.EventHandler(this.tsbVoltar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 38);
            this.label1.TabIndex = 35;
            this.label1.Text = "BUSCAR";
            // 
            // txtBusca
            // 
            this.txtBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusca.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtBusca.Location = new System.Drawing.Point(191, 69);
            this.txtBusca.MaxLength = 50;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(590, 44);
            this.txtBusca.TabIndex = 34;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeProdutoDataGridViewTextBoxColumn,
            this.cATEGORIADOPRODUTODataGridViewTextBoxColumn,
            this.cÓDIGORÁPIDODataGridViewTextBoxColumn,
            this.pONTOSDataGridViewTextBoxColumn,
            this.vALORDECOMPRADataGridViewTextBoxColumn,
            this.vALORDEVENDADataGridViewTextBoxColumn,
            this.lUCRODataGridViewTextBoxColumn,
            this.sESSÃODataGridViewTextBoxColumn});
            this.dgvProdutos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvProdutos.DataSource = this.vwProdutosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.GridColor = System.Drawing.Color.Black;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 143);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 30;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(2010, 792);
            this.dgvProdutos.TabIndex = 33;
            // 
            // vwProdutosBindingSource
            // 
            this.vwProdutosBindingSource.DataMember = "vw_Produtos";
            this.vwProdutosBindingSource.DataSource = this.maryKayDataSet3;
            // 
            // maryKayDataSet3
            // 
            this.maryKayDataSet3.DataSetName = "MaryKayDataSet3";
            this.maryKayDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
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
            this.nm.Size = new System.Drawing.Size(261, 68);
            this.nm.TabIndex = 32;
            this.nm.Text = "Produtos";
            // 
            // vw_ProdutosTableAdapter
            // 
            this.vw_ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // NomeProdutoDataGridViewTextBoxColumn
            // 
            this.NomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.NomeProdutoDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.NomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.NomeProdutoDataGridViewTextBoxColumn.Name = "NomeProdutoDataGridViewTextBoxColumn";
            this.NomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.NomeProdutoDataGridViewTextBoxColumn.Width = 350;
            // 
            // cATEGORIADOPRODUTODataGridViewTextBoxColumn
            // 
            this.cATEGORIADOPRODUTODataGridViewTextBoxColumn.DataPropertyName = "CATEGORIA DO PRODUTO";
            this.cATEGORIADOPRODUTODataGridViewTextBoxColumn.HeaderText = "CATEGORIA DO PRODUTO";
            this.cATEGORIADOPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cATEGORIADOPRODUTODataGridViewTextBoxColumn.Name = "cATEGORIADOPRODUTODataGridViewTextBoxColumn";
            this.cATEGORIADOPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cATEGORIADOPRODUTODataGridViewTextBoxColumn.Width = 350;
            // 
            // cÓDIGORÁPIDODataGridViewTextBoxColumn
            // 
            this.cÓDIGORÁPIDODataGridViewTextBoxColumn.DataPropertyName = "CÓDIGO RÁPIDO";
            this.cÓDIGORÁPIDODataGridViewTextBoxColumn.HeaderText = "CÓDIGO RÁPIDO";
            this.cÓDIGORÁPIDODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cÓDIGORÁPIDODataGridViewTextBoxColumn.Name = "cÓDIGORÁPIDODataGridViewTextBoxColumn";
            this.cÓDIGORÁPIDODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pONTOSDataGridViewTextBoxColumn
            // 
            this.pONTOSDataGridViewTextBoxColumn.DataPropertyName = "PONTOS";
            this.pONTOSDataGridViewTextBoxColumn.HeaderText = "PONTOS";
            this.pONTOSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pONTOSDataGridViewTextBoxColumn.Name = "pONTOSDataGridViewTextBoxColumn";
            this.pONTOSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALORDECOMPRADataGridViewTextBoxColumn
            // 
            this.vALORDECOMPRADataGridViewTextBoxColumn.DataPropertyName = "VALOR DE COMPRA";
            this.vALORDECOMPRADataGridViewTextBoxColumn.HeaderText = "VALOR DE COMPRA";
            this.vALORDECOMPRADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vALORDECOMPRADataGridViewTextBoxColumn.Name = "vALORDECOMPRADataGridViewTextBoxColumn";
            this.vALORDECOMPRADataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORDECOMPRADataGridViewTextBoxColumn.Width = 200;
            // 
            // vALORDEVENDADataGridViewTextBoxColumn
            // 
            this.vALORDEVENDADataGridViewTextBoxColumn.DataPropertyName = "VALOR DE VENDA";
            this.vALORDEVENDADataGridViewTextBoxColumn.HeaderText = "VALOR DE VENDA";
            this.vALORDEVENDADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vALORDEVENDADataGridViewTextBoxColumn.Name = "vALORDEVENDADataGridViewTextBoxColumn";
            this.vALORDEVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORDEVENDADataGridViewTextBoxColumn.Width = 200;
            // 
            // lUCRODataGridViewTextBoxColumn
            // 
            this.lUCRODataGridViewTextBoxColumn.DataPropertyName = "LUCRO";
            this.lUCRODataGridViewTextBoxColumn.HeaderText = "LUCRO";
            this.lUCRODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lUCRODataGridViewTextBoxColumn.Name = "lUCRODataGridViewTextBoxColumn";
            this.lUCRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sESSÃODataGridViewTextBoxColumn
            // 
            this.sESSÃODataGridViewTextBoxColumn.DataPropertyName = "SESSÃO";
            this.sESSÃODataGridViewTextBoxColumn.HeaderText = "SESSÃO";
            this.sESSÃODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sESSÃODataGridViewTextBoxColumn.Name = "sESSÃODataGridViewTextBoxColumn";
            this.sESSÃODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(2034, 980);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maryKayDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAtualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbVoltar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private MaryKayDataSet3 maryKayDataSet3;
        private System.Windows.Forms.BindingSource vwProdutosBindingSource;
        private MaryKayDataSet3TableAdapters.vw_ProdutosTableAdapter vw_ProdutosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cATEGORIADOPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cÓDIGORÁPIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDECOMPRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDEVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUCRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sESSÃODataGridViewTextBoxColumn;
    }
}