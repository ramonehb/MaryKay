﻿
namespace MaryKay
{
    partial class fCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCadastroUsuario));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.bFechar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbConfirmaSenha = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(212, 638);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(677, 44);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtNome.Location = new System.Drawing.Point(209, 383);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(993, 44);
            this.txtNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 48);
            this.label2.TabIndex = 34;
            this.label2.Text = "EMAIL";
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.BackColor = System.Drawing.Color.Transparent;
            this.nm.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.nm.ForeColor = System.Drawing.Color.Black;
            this.nm.Location = new System.Drawing.Point(44, 379);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(133, 48);
            this.nm.TabIndex = 31;
            this.nm.Text = "NOME";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFinalizar.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(967, 871);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(329, 103);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "FINALIZAR CADASTRO";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtSenha.Location = new System.Drawing.Point(212, 508);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(677, 44);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 48);
            this.label1.TabIndex = 47;
            this.label1.Text = "SENHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(931, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 48);
            this.label3.TabIndex = 49;
            this.label3.Text = "CONFIRMAR SENHA";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtConfirmaSenha.Location = new System.Drawing.Point(1351, 505);
            this.txtConfirmaSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmaSenha.MaxLength = 50;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(677, 44);
            this.txtConfirmaSenha.TabIndex = 2;
            this.txtConfirmaSenha.UseSystemPasswordChar = true;
            // 
            // bFechar
            // 
            this.bFechar.BackColor = System.Drawing.Color.Red;
            this.bFechar.Font = new System.Drawing.Font("Arial Black", 20F);
            this.bFechar.ForeColor = System.Drawing.Color.White;
            this.bFechar.Location = new System.Drawing.Point(1984, -4);
            this.bFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(59, 60);
            this.bFechar.TabIndex = 51;
            this.bFechar.Text = "X";
            this.bFechar.UseVisualStyleBackColor = false;
            this.bFechar.Click += new System.EventHandler(this.bFechar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbNome.ForeColor = System.Drawing.Color.Red;
            this.lbNome.Location = new System.Drawing.Point(271, 322);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(0, 48);
            this.lbNome.TabIndex = 52;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbSenha.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbSenha.ForeColor = System.Drawing.Color.Red;
            this.lbSenha.Location = new System.Drawing.Point(265, 444);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(0, 48);
            this.lbSenha.TabIndex = 53;
            // 
            // lbConfirmaSenha
            // 
            this.lbConfirmaSenha.AutoSize = true;
            this.lbConfirmaSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbConfirmaSenha.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbConfirmaSenha.ForeColor = System.Drawing.Color.Red;
            this.lbConfirmaSenha.Location = new System.Drawing.Point(1385, 444);
            this.lbConfirmaSenha.Name = "lbConfirmaSenha";
            this.lbConfirmaSenha.Size = new System.Drawing.Size(0, 48);
            this.lbConfirmaSenha.TabIndex = 54;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbEmail.ForeColor = System.Drawing.Color.Red;
            this.lbEmail.Location = new System.Drawing.Point(265, 583);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 48);
            this.lbEmail.TabIndex = 55;
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(1269, 645);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(269, 24);
            this.cbTipoUsuario.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(945, 633);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 48);
            this.label4.TabIndex = 57;
            this.label4.Text = "TIPO USÚARIO";
            // 
            // fCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(2057, 1006);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbConfirmaSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.bFechar);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Button bFechar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbConfirmaSenha;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label label4;
    }
}