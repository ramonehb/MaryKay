
namespace MaryKay
{
    partial class AlterarQuantidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarQuantidade));
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lbNova = new System.Windows.Forms.Label();
            this.lbAtual = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nudAtual = new System.Windows.Forms.NumericUpDown();
            this.nudNovo = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNovaErro = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lbProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNovo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFinalizar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFinalizar.Location = new System.Drawing.Point(237, 312);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(165, 42);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "ALTERAR";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lbNova
            // 
            this.lbNova.AutoSize = true;
            this.lbNova.BackColor = System.Drawing.Color.Transparent;
            this.lbNova.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lbNova.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNova.Location = new System.Drawing.Point(350, 199);
            this.lbNova.Name = "lbNova";
            this.lbNova.Size = new System.Drawing.Size(189, 26);
            this.lbNova.TabIndex = 68;
            this.lbNova.Text = "Nova Quantidade";
            this.lbNova.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAtual
            // 
            this.lbAtual.AutoSize = true;
            this.lbAtual.BackColor = System.Drawing.Color.Transparent;
            this.lbAtual.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lbAtual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbAtual.Location = new System.Drawing.Point(85, 199);
            this.lbAtual.Name = "lbAtual";
            this.lbAtual.Size = new System.Drawing.Size(186, 26);
            this.lbAtual.TabIndex = 67;
            this.lbAtual.Text = "Quantidade Atual";
            this.lbAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(228, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // nudAtual
            // 
            this.nudAtual.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.nudAtual.Hexadecimal = true;
            this.nudAtual.Location = new System.Drawing.Point(136, 249);
            this.nudAtual.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudAtual.Name = "nudAtual";
            this.nudAtual.ReadOnly = true;
            this.nudAtual.Size = new System.Drawing.Size(142, 44);
            this.nudAtual.TabIndex = 100;
            this.nudAtual.TabStop = false;
            this.nudAtual.ThousandsSeparator = true;
            // 
            // nudNovo
            // 
            this.nudNovo.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.nudNovo.Hexadecimal = true;
            this.nudNovo.Location = new System.Drawing.Point(384, 249);
            this.nudNovo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudNovo.Name = "nudNovo";
            this.nudNovo.Size = new System.Drawing.Size(142, 44);
            this.nudNovo.TabIndex = 0;
            this.nudNovo.ThousandsSeparator = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(250, 249);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 79;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(498, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // lbNovaErro
            // 
            this.lbNovaErro.AutoSize = true;
            this.lbNovaErro.BackColor = System.Drawing.Color.Transparent;
            this.lbNovaErro.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lbNovaErro.ForeColor = System.Drawing.Color.Red;
            this.lbNovaErro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNovaErro.Location = new System.Drawing.Point(277, 216);
            this.lbNovaErro.Name = "lbNovaErro";
            this.lbNovaErro.Size = new System.Drawing.Size(0, 28);
            this.lbNovaErro.TabIndex = 81;
            this.lbNovaErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tsbAlterar,
            this.toolStripSeparator3,
            this.toolStripSeparator1,
            this.toolStripSeparator4});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(574, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(74, 52);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbAlterar
            // 
            this.tsbAlterar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAlterar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.tsbAlterar.ForeColor = System.Drawing.Color.Black;
            this.tsbAlterar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlterar.Image")));
            this.tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterar.Name = "tsbAlterar";
            this.tsbAlterar.Size = new System.Drawing.Size(49, 49);
            this.tsbAlterar.Click += new System.EventHandler(this.tsbAlterar_Click);
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
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.BackColor = System.Drawing.Color.Transparent;
            this.lbProduto.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lbProduto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbProduto.Location = new System.Drawing.Point(114, 138);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(0, 29);
            this.lbProduto.TabIndex = 83;
            this.lbProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlterarQuantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(668, 379);
            this.ControlBox = false;
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.lbNovaErro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.nudNovo);
            this.Controls.Add(this.nudAtual);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lbNova);
            this.Controls.Add(this.lbAtual);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AlterarQuantidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Quantidade";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNovo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lbNova;
        private System.Windows.Forms.Label lbAtual;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown nudAtual;
        private System.Windows.Forms.NumericUpDown nudNovo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNovaErro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAlterar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label lbProduto;
    }
}