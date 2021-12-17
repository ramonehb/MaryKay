
namespace MaryKay
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.lblData = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lNome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lRua = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lNumero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lCPF = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.Red;
            this.lblData.Location = new System.Drawing.Point(1376, 535);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 27);
            this.lblData.TabIndex = 43;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtTelefone.Location = new System.Drawing.Point(266, 613);
            this.txtTelefone.Mask = "(00) 00000 - 0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(278, 44);
            this.txtTelefone.TabIndex = 32;
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.BackColor = System.Drawing.Color.Transparent;
            this.lNome.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.lNome.ForeColor = System.Drawing.Color.Red;
            this.lNome.Location = new System.Drawing.Point(498, 357);
            this.lNome.Name = "lNome";
            this.lNome.Size = new System.Drawing.Size(0, 38);
            this.lNome.TabIndex = 40;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(607, 178);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 27);
            this.lblUser.TabIndex = 39;
            // 
            // dtNascimento
            // 
            this.dtNascimento.Font = new System.Drawing.Font("Arial Black", 17F, System.Drawing.FontStyle.Bold);
            this.dtNascimento.Location = new System.Drawing.Point(1205, 613);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(743, 47);
            this.dtNascimento.TabIndex = 33;
            this.dtNascimento.Value = new System.DateTime(2020, 1, 1, 10, 10, 10, 0);
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.BackColor = System.Drawing.Color.Transparent;
            this.checkEmail.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.checkEmail.ForeColor = System.Drawing.Color.Black;
            this.checkEmail.Location = new System.Drawing.Point(1213, 506);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(744, 40);
            this.checkEmail.TabIndex = 31;
            this.checkEmail.Text = "RECEBER E-MAILS COM PROMOÇÔES E NOVIDADES";
            this.checkEmail.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFinalizar.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(1037, 871);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(329, 104);
            this.btnFinalizar.TabIndex = 37;
            this.btnFinalizar.Text = "FINALIZAR CADASTRO";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Firebrick;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(597, 871);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(299, 104);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "LIMPAR OS CAMPOS";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(185, 506);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(971, 44);
            this.txtEmail.TabIndex = 28;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtNome.Location = new System.Drawing.Point(183, 399);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(993, 44);
            this.txtNome.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(730, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 48);
            this.label4.TabIndex = 34;
            this.label4.Text = "DATA DE NASCIMENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 48);
            this.label2.TabIndex = 30;
            this.label2.Text = "EMAIL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 48);
            this.label1.TabIndex = 29;
            this.label1.Text = "TELEFONE";
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.BackColor = System.Drawing.Color.Transparent;
            this.nm.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.nm.ForeColor = System.Drawing.Color.Black;
            this.nm.Location = new System.Drawing.Point(17, 395);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(133, 48);
            this.nm.TabIndex = 26;
            this.nm.Text = "NOME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txtRua
            // 
            this.txtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRua.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtRua.Location = new System.Drawing.Point(646, 731);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(971, 44);
            this.txtRua.TabIndex = 45;
            // 
            // lRua
            // 
            this.lRua.AutoSize = true;
            this.lRua.BackColor = System.Drawing.Color.Transparent;
            this.lRua.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lRua.ForeColor = System.Drawing.Color.Black;
            this.lRua.Location = new System.Drawing.Point(520, 727);
            this.lRua.Name = "lRua";
            this.lRua.Size = new System.Drawing.Size(98, 48);
            this.lRua.TabIndex = 46;
            this.lRua.Text = "RUA";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtNumero.Location = new System.Drawing.Point(1774, 731);
            this.txtNumero.MaxLength = 50;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(222, 44);
            this.txtNumero.TabIndex = 49;
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.BackColor = System.Drawing.Color.Transparent;
            this.lNumero.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lNumero.ForeColor = System.Drawing.Color.Black;
            this.lNumero.Location = new System.Drawing.Point(1677, 727);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(62, 48);
            this.lNumero.TabIndex = 50;
            this.lNumero.Text = "Nº";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2400, 637);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 48);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nº";
            // 
            // lCPF
            // 
            this.lCPF.AutoSize = true;
            this.lCPF.BackColor = System.Drawing.Color.Transparent;
            this.lCPF.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.lCPF.ForeColor = System.Drawing.Color.Red;
            this.lCPF.Location = new System.Drawing.Point(1465, 358);
            this.lCPF.Name = "lCPF";
            this.lCPF.Size = new System.Drawing.Size(0, 38);
            this.lCPF.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1274, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 48);
            this.label7.TabIndex = 53;
            this.label7.Text = "CPF";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.mtbCpf.Location = new System.Drawing.Point(1414, 399);
            this.mtbCpf.Mask = "###,###,###-##";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(325, 44);
            this.mtbCpf.TabIndex = 57;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbCEP
            // 
            this.mtbCEP.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.mtbCEP.Location = new System.Drawing.Point(174, 731);
            this.mtbCEP.Mask = "#####-###";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(261, 44);
            this.mtbCEP.TabIndex = 58;
            this.mtbCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 727);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 48);
            this.label3.TabIndex = 59;
            this.label3.Text = "CEP";
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(2034, 980);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lCPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lNumero);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lRua);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lNome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CadastroCliente";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label label3;
    }
}