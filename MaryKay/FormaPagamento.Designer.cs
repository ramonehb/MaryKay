
namespace MaryKay
{
    partial class FormaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPagamento));
            this.nm = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFechar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.lTrocoFalta = new System.Windows.Forms.Label();
            this.nudTotalAPagar = new System.Windows.Forms.NumericUpDown();
            this.nudTotalRecebido = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nudTroco = new System.Windows.Forms.NumericUpDown();
            this.cboFormaPagamento = new System.Windows.Forms.ComboBox();
            this.formaPagamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formaPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxForma = new MaryKay.comboBoxForma();
            this.formaPagamentoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.formaPagamentoTableAdapter = new MaryKay.comboBoxFormaTableAdapters.FormaPagamentoTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalRecebido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTroco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxForma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.BackColor = System.Drawing.Color.Transparent;
            this.nm.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.nm.ForeColor = System.Drawing.Color.Black;
            this.nm.Location = new System.Drawing.Point(12, 210);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(249, 35);
            this.nm.TabIndex = 80;
            this.nm.Text = "TOTAL A PAGAR";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFinalizar.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFinalizar.Location = new System.Drawing.Point(302, 531);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(232, 66);
            this.btnFinalizar.TabIndex = 78;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tsbFechar,
            this.toolStripSeparator3,
            this.toolStripSeparator1,
            this.toolStripSeparator4});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(754, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(113, 52);
            this.toolStrip1.TabIndex = 79;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbFechar
            // 
            this.tsbFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbFechar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.tsbFechar.ForeColor = System.Drawing.Color.Black;
            this.tsbFechar.Image = ((System.Drawing.Image)(resources.GetObject("tsbFechar.Image")));
            this.tsbFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFechar.Name = "tsbFechar";
            this.tsbFechar.Size = new System.Drawing.Size(49, 49);
            this.tsbFechar.Click += new System.EventHandler(this.tsbFechar_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 35);
            this.label1.TabIndex = 82;
            this.label1.Text = "TOTAL RECEBIDO";
            // 
            // lTrocoFalta
            // 
            this.lTrocoFalta.AutoSize = true;
            this.lTrocoFalta.BackColor = System.Drawing.Color.Transparent;
            this.lTrocoFalta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lTrocoFalta.ForeColor = System.Drawing.Color.Black;
            this.lTrocoFalta.Location = new System.Drawing.Point(12, 371);
            this.lTrocoFalta.Name = "lTrocoFalta";
            this.lTrocoFalta.Size = new System.Drawing.Size(123, 35);
            this.lTrocoFalta.TabIndex = 84;
            this.lTrocoFalta.Text = "TROCO";
            // 
            // nudTotalAPagar
            // 
            this.nudTotalAPagar.DecimalPlaces = 2;
            this.nudTotalAPagar.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.nudTotalAPagar.Location = new System.Drawing.Point(406, 210);
            this.nudTotalAPagar.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudTotalAPagar.Name = "nudTotalAPagar";
            this.nudTotalAPagar.Size = new System.Drawing.Size(427, 44);
            this.nudTotalAPagar.TabIndex = 85;
            this.nudTotalAPagar.ThousandsSeparator = true;
            // 
            // nudTotalRecebido
            // 
            this.nudTotalRecebido.DecimalPlaces = 2;
            this.nudTotalRecebido.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.nudTotalRecebido.Location = new System.Drawing.Point(406, 288);
            this.nudTotalRecebido.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudTotalRecebido.Name = "nudTotalRecebido";
            this.nudTotalRecebido.Size = new System.Drawing.Size(427, 44);
            this.nudTotalRecebido.TabIndex = 87;
            this.nudTotalRecebido.ThousandsSeparator = true;
            this.nudTotalRecebido.ValueChanged += new System.EventHandler(this.nudTotalRecebido_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(812, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 329);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 90;
            this.pictureBox2.TabStop = false;
            // 
            // nudTroco
            // 
            this.nudTroco.DecimalPlaces = 2;
            this.nudTroco.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.nudTroco.Location = new System.Drawing.Point(406, 362);
            this.nudTroco.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudTroco.Name = "nudTroco";
            this.nudTroco.Size = new System.Drawing.Size(427, 44);
            this.nudTroco.TabIndex = 89;
            this.nudTroco.ThousandsSeparator = true;
            // 
            // cboFormaPagamento
            // 
            this.cboFormaPagamento.DataSource = this.formaPagamentoBindingSource2;
            this.cboFormaPagamento.DisplayMember = "NM_Descricao";
            this.cboFormaPagamento.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.cboFormaPagamento.FormattingEnabled = true;
            this.cboFormaPagamento.Location = new System.Drawing.Point(406, 441);
            this.cboFormaPagamento.Name = "cboFormaPagamento";
            this.cboFormaPagamento.Size = new System.Drawing.Size(403, 50);
            this.cboFormaPagamento.TabIndex = 91;
            this.cboFormaPagamento.ValueMember = "ID_FormaPagamento";
            // 
            // formaPagamentoBindingSource
            // 
            this.formaPagamentoBindingSource.DataMember = "FormaPagamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 34);
            this.label3.TabIndex = 92;
            this.label3.Text = "FORMA DE PAGAMENTO";
            // 
            // comboBoxForma
            // 
            this.comboBoxForma.DataSetName = "comboBoxForma";
            this.comboBoxForma.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formaPagamentoBindingSource2
            // 
            this.formaPagamentoBindingSource2.DataMember = "FormaPagamento";
            this.formaPagamentoBindingSource2.DataSource = this.comboBoxForma;
            // 
            // formaPagamentoTableAdapter
            // 
            this.formaPagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // FormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(845, 609);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboFormaPagamento);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nudTroco);
            this.Controls.Add(this.nudTotalRecebido);
            this.Controls.Add(this.nudTotalAPagar);
            this.Controls.Add(this.lTrocoFalta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaPagamento";
            this.Load += new System.EventHandler(this.FormaPagamento_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalRecebido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTroco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxForma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formaPagamentoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbFechar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTrocoFalta;
        private System.Windows.Forms.NumericUpDown nudTotalAPagar;
        private System.Windows.Forms.NumericUpDown nudTotalRecebido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown nudTroco;
        private System.Windows.Forms.ComboBox cboFormaPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource formaPagamentoBindingSource;
        private System.Windows.Forms.BindingSource formaPagamentoBindingSource1;
        private comboBoxForma comboBoxForma;
        private System.Windows.Forms.BindingSource formaPagamentoBindingSource2;
        private comboBoxFormaTableAdapters.FormaPagamentoTableAdapter formaPagamentoTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}