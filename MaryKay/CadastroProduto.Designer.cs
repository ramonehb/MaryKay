﻿
namespace MaryKay
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.nm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQtd = new System.Windows.Forms.Label();
            this.cboSessao = new System.Windows.Forms.ComboBox();
            this.cboTipoProduto = new System.Windows.Forms.ComboBox();
            this.tipoProdutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.maryKayDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maryKayDataSet1 = new MaryKay.MaryKayDataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bFechar = new System.Windows.Forms.Button();
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbPago = new System.Windows.Forms.Label();
            this.lbVenda = new System.Windows.Forms.Label();
            this.lbSessao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCodigoRapido = new System.Windows.Forms.Label();
            this.tipoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_ProdutoTableAdapter = new MaryKay.MaryKayDataSet1TableAdapters.Tipo_ProdutoTableAdapter();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.nudVL_Venda = new System.Windows.Forms.NumericUpDown();
            this.nudVL_Pago = new System.Windows.Forms.NumericUpDown();
            this.nudPontos = new System.Windows.Forms.NumericUpDown();
            this.nudCodigoRapido = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maryKayDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maryKayDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVL_Venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVL_Pago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoRapido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeProduto.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtNomeProduto.Location = new System.Drawing.Point(388, 373);
            this.txtNomeProduto.MaxLength = 50;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(1522, 44);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.BackColor = System.Drawing.Color.Transparent;
            this.nm.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.nm.ForeColor = System.Drawing.Color.Black;
            this.nm.Location = new System.Drawing.Point(53, 370);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(204, 48);
            this.nm.TabIndex = 28;
            this.nm.Text = "PRODUTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 742);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 48);
            this.label1.TabIndex = 30;
            this.label1.Text = "CODIGO RÁPIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(53, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 48);
            this.label2.TabIndex = 32;
            this.label2.Text = "VALOR PAGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(793, 624);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 48);
            this.label3.TabIndex = 34;
            this.label3.Text = "VALOR DE VENDA";
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.BackColor = System.Drawing.Color.Transparent;
            this.labelQtd.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.labelQtd.ForeColor = System.Drawing.Color.Black;
            this.labelQtd.Location = new System.Drawing.Point(1427, 499);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(269, 48);
            this.labelQtd.TabIndex = 36;
            this.labelQtd.Text = "QUANTIDADE";
            // 
            // cboSessao
            // 
            this.cboSessao.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.cboSessao.FormattingEnabled = true;
            this.cboSessao.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSessao.Location = new System.Drawing.Point(1779, 621);
            this.cboSessao.Name = "cboSessao";
            this.cboSessao.Size = new System.Drawing.Size(92, 50);
            this.cboSessao.TabIndex = 5;
            // 
            // cboTipoProduto
            // 
            this.cboTipoProduto.DataSource = this.tipoProdutoBindingSource1;
            this.cboTipoProduto.DisplayMember = "Categoria";
            this.cboTipoProduto.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.cboTipoProduto.FormattingEnabled = true;
            this.cboTipoProduto.Location = new System.Drawing.Point(388, 497);
            this.cboTipoProduto.Name = "cboTipoProduto";
            this.cboTipoProduto.Size = new System.Drawing.Size(975, 50);
            this.cboTipoProduto.TabIndex = 1;
            this.cboTipoProduto.ValueMember = "ID_TipoProduto";
            // 
            // tipoProdutoBindingSource1
            // 
            this.tipoProdutoBindingSource1.DataMember = "Tipo_Produto";
            this.tipoProdutoBindingSource1.DataSource = this.maryKayDataSet1BindingSource;
            // 
            // maryKayDataSet1BindingSource
            // 
            this.maryKayDataSet1BindingSource.DataSource = this.maryKayDataSet1;
            this.maryKayDataSet1BindingSource.Position = 0;
            // 
            // maryKayDataSet1
            // 
            this.maryKayDataSet1.DataSetName = "MaryKayDataSet1";
            this.maryKayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 48);
            this.label5.TabIndex = 39;
            this.label5.Text = "CATEGORIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1571, 623);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 48);
            this.label6.TabIndex = 40;
            this.label6.Text = "SESSÃO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(622, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1014, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // bFechar
            // 
            this.bFechar.Location = new System.Drawing.Point(0, 0);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(75, 23);
            this.bFechar.TabIndex = 86;
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeProduto.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbNomeProduto.ForeColor = System.Drawing.Color.Red;
            this.lbNomeProduto.Location = new System.Drawing.Point(793, 303);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(0, 48);
            this.lbNomeProduto.TabIndex = 63;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbCategoria.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbCategoria.ForeColor = System.Drawing.Color.Red;
            this.lbCategoria.Location = new System.Drawing.Point(615, 434);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(0, 48);
            this.lbCategoria.TabIndex = 64;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lbQuantidade.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbQuantidade.ForeColor = System.Drawing.Color.Red;
            this.lbQuantidade.Location = new System.Drawing.Point(1454, 434);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(0, 48);
            this.lbQuantidade.TabIndex = 65;
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.BackColor = System.Drawing.Color.Transparent;
            this.lbPago.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbPago.ForeColor = System.Drawing.Color.Red;
            this.lbPago.Location = new System.Drawing.Point(380, 563);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(0, 48);
            this.lbPago.TabIndex = 66;
            // 
            // lbVenda
            // 
            this.lbVenda.AutoSize = true;
            this.lbVenda.BackColor = System.Drawing.Color.Transparent;
            this.lbVenda.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbVenda.ForeColor = System.Drawing.Color.Red;
            this.lbVenda.Location = new System.Drawing.Point(1187, 563);
            this.lbVenda.Name = "lbVenda";
            this.lbVenda.Size = new System.Drawing.Size(0, 48);
            this.lbVenda.TabIndex = 67;
            // 
            // lbSessao
            // 
            this.lbSessao.AutoSize = true;
            this.lbSessao.BackColor = System.Drawing.Color.Transparent;
            this.lbSessao.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbSessao.ForeColor = System.Drawing.Color.Red;
            this.lbSessao.Location = new System.Drawing.Point(1653, 563);
            this.lbSessao.Name = "lbSessao";
            this.lbSessao.Size = new System.Drawing.Size(0, 48);
            this.lbSessao.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(964, 742);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 48);
            this.label7.TabIndex = 70;
            this.label7.Text = "PONTOS";
            // 
            // lbCodigoRapido
            // 
            this.lbCodigoRapido.AutoSize = true;
            this.lbCodigoRapido.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigoRapido.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbCodigoRapido.ForeColor = System.Drawing.Color.Red;
            this.lbCodigoRapido.Location = new System.Drawing.Point(277, 691);
            this.lbCodigoRapido.Name = "lbCodigoRapido";
            this.lbCodigoRapido.Size = new System.Drawing.Size(0, 48);
            this.lbCodigoRapido.TabIndex = 71;
            // 
            // tipoProdutoBindingSource
            // 
            this.tipoProdutoBindingSource.DataMember = "Tipo_Produto";
            this.tipoProdutoBindingSource.DataSource = this.maryKayDataSet1;
            // 
            // tipo_ProdutoTableAdapter
            // 
            this.tipo_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.nudQuantidade.Location = new System.Drawing.Point(1751, 503);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 44);
            this.nudQuantidade.TabIndex = 2;
            this.nudQuantidade.ThousandsSeparator = true;
            // 
            // nudVL_Venda
            // 
            this.nudVL_Venda.DecimalPlaces = 2;
            this.nudVL_Venda.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.nudVL_Venda.Location = new System.Drawing.Point(1186, 627);
            this.nudVL_Venda.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudVL_Venda.Name = "nudVL_Venda";
            this.nudVL_Venda.Size = new System.Drawing.Size(358, 44);
            this.nudVL_Venda.TabIndex = 4;
            this.nudVL_Venda.ThousandsSeparator = true;
            // 
            // nudVL_Pago
            // 
            this.nudVL_Pago.DecimalPlaces = 2;
            this.nudVL_Pago.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.nudVL_Pago.Location = new System.Drawing.Point(388, 628);
            this.nudVL_Pago.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudVL_Pago.Name = "nudVL_Pago";
            this.nudVL_Pago.Size = new System.Drawing.Size(358, 44);
            this.nudVL_Pago.TabIndex = 3;
            this.nudVL_Pago.ThousandsSeparator = true;
            // 
            // nudPontos
            // 
            this.nudPontos.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.nudPontos.Hexadecimal = true;
            this.nudPontos.Location = new System.Drawing.Point(1186, 742);
            this.nudPontos.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudPontos.Name = "nudPontos";
            this.nudPontos.Size = new System.Drawing.Size(358, 44);
            this.nudPontos.TabIndex = 7;
            this.nudPontos.ThousandsSeparator = true;
            // 
            // nudCodigoRapido
            // 
            this.nudCodigoRapido.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.nudCodigoRapido.Hexadecimal = true;
            this.nudCodigoRapido.Location = new System.Drawing.Point(388, 746);
            this.nudCodigoRapido.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudCodigoRapido.Name = "nudCodigoRapido";
            this.nudCodigoRapido.Size = new System.Drawing.Size(358, 44);
            this.nudCodigoRapido.TabIndex = 6;
            this.nudCodigoRapido.ThousandsSeparator = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1524, 621);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(726, 621);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 78;
            this.pictureBox3.TabStop = false;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdProduto.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtIdProduto.Location = new System.Drawing.Point(388, 268);
            this.txtIdProduto.MaxLength = 50;
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(62, 44);
            this.txtIdProduto.TabIndex = 79;
            this.txtIdProduto.Visible = false;
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.ForestGreen;
            this.btFinalizar.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.Color.White;
            this.btFinalizar.Location = new System.Drawing.Point(878, 904);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(255, 77);
            this.btFinalizar.TabIndex = 81;
            this.btFinalizar.Text = "FINALIZAR";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
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
            this.toolStrip2.Location = new System.Drawing.Point(1862, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(154, 52);
            this.toolStrip2.TabIndex = 85;
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
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toolStripSeparator1,
            this.toolStripSeparator4});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1992, 23);
            this.toolStrip1.TabIndex = 84;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
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
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1992, 1006);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.lbCodigoRapido);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nudCodigoRapido);
            this.Controls.Add(this.nudPontos);
            this.Controls.Add(this.nudVL_Pago);
            this.Controls.Add(this.nudVL_Venda);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbSessao);
            this.Controls.Add(this.lbVenda);
            this.Controls.Add(this.lbPago);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbNomeProduto);
            this.Controls.Add(this.bFechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTipoProduto);
            this.Controls.Add(this.cboSessao);
            this.Controls.Add(this.labelQtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.nm);
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maryKayDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maryKayDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVL_Venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVL_Pago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoRapido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQtd;
        private System.Windows.Forms.ComboBox cboSessao;
        private System.Windows.Forms.ComboBox cboTipoProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bFechar;
        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbPago;
        private System.Windows.Forms.Label lbVenda;
        private System.Windows.Forms.Label lbSessao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCodigoRapido;
        private MaryKayDataSet1 maryKayDataSet1;
        private System.Windows.Forms.BindingSource tipoProdutoBindingSource;
        private MaryKayDataSet1TableAdapters.Tipo_ProdutoTableAdapter tipo_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource tipoProdutoBindingSource1;
        private System.Windows.Forms.BindingSource maryKayDataSet1BindingSource;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.NumericUpDown nudVL_Venda;
        private System.Windows.Forms.NumericUpDown nudVL_Pago;
        private System.Windows.Forms.NumericUpDown nudPontos;
        private System.Windows.Forms.NumericUpDown nudCodigoRapido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}