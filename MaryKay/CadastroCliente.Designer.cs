
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
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lNome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lNumero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lTelefone = new System.Windows.Forms.Label();
            this.bFechar = new System.Windows.Forms.Button();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.Red;
            this.lblData.Location = new System.Drawing.Point(1390, 520);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 27);
            this.lblData.TabIndex = 43;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.mtbTelefone.Location = new System.Drawing.Point(280, 598);
            this.mtbTelefone.Mask = "(00) 00000 - 0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(278, 44);
            this.mtbTelefone.TabIndex = 4;
            // 
            // lNome
            // 
            this.lNome.AutoSize = true;
            this.lNome.BackColor = System.Drawing.Color.Transparent;
            this.lNome.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.lNome.ForeColor = System.Drawing.Color.Red;
            this.lNome.Location = new System.Drawing.Point(512, 342);
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
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.BackColor = System.Drawing.Color.Transparent;
            this.checkEmail.Enabled = false;
            this.checkEmail.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.checkEmail.ForeColor = System.Drawing.Color.Black;
            this.checkEmail.Location = new System.Drawing.Point(1220, 491);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(744, 40);
            this.checkEmail.TabIndex = 3;
            this.checkEmail.Text = "RECEBER E-MAILS COM PROMOÇÔES E NOVIDADES";
            this.checkEmail.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFinalizar.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(876, 891);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(255, 77);
            this.btnFinalizar.TabIndex = 37;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(199, 491);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(971, 44);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtNome.Location = new System.Drawing.Point(197, 384);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(993, 44);
            this.txtNome.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(791, 594);
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
            this.label2.Location = new System.Drawing.Point(34, 487);
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
            this.label1.Location = new System.Drawing.Point(31, 595);
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
            this.nm.Location = new System.Drawing.Point(31, 380);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(133, 48);
            this.nm.TabIndex = 26;
            this.nm.Text = "NOME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(569, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1014, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txtRua
            // 
            this.txtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRua.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtRua.Location = new System.Drawing.Point(721, 719);
            this.txtRua.MaxLength = 50;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(903, 44);
            this.txtRua.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtNumero.Location = new System.Drawing.Point(1774, 720);
            this.txtNumero.MaxLength = 50;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(222, 44);
            this.txtNumero.TabIndex = 8;
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.BackColor = System.Drawing.Color.Transparent;
            this.lNumero.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lNumero.ForeColor = System.Drawing.Color.Black;
            this.lNumero.Location = new System.Drawing.Point(1677, 716);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1288, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 48);
            this.label7.TabIndex = 53;
            this.label7.Text = "CPF";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.mtbCpf.Location = new System.Drawing.Point(1428, 384);
            this.mtbCpf.Mask = "###,###,###-##";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(325, 44);
            this.mtbCpf.TabIndex = 1;
            this.mtbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbCEP
            // 
            this.mtbCEP.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.mtbCEP.Location = new System.Drawing.Point(188, 716);
            this.mtbCEP.Mask = "#####-###";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(261, 44);
            this.mtbCEP.TabIndex = 6;
            this.mtbCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 712);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 48);
            this.label3.TabIndex = 59;
            this.label3.Text = "CEP";
            // 
            // lTelefone
            // 
            this.lTelefone.AutoSize = true;
            this.lTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lTelefone.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.lTelefone.ForeColor = System.Drawing.Color.Red;
            this.lTelefone.Location = new System.Drawing.Point(261, 557);
            this.lTelefone.Name = "lTelefone";
            this.lTelefone.Size = new System.Drawing.Size(0, 38);
            this.lTelefone.TabIndex = 60;
            // 
            // bFechar
            // 
            this.bFechar.BackColor = System.Drawing.Color.Red;
            this.bFechar.Font = new System.Drawing.Font("Arial Black", 20F);
            this.bFechar.ForeColor = System.Drawing.Color.White;
            this.bFechar.Location = new System.Drawing.Point(1972, 3);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(59, 60);
            this.bFechar.TabIndex = 61;
            this.bFechar.Text = "X";
            this.bFechar.UseVisualStyleBackColor = false;
            this.bFechar.Click += new System.EventHandler(this.bFechar_Click);
            // 
            // dtNascimento
            // 
            this.dtNascimento.Font = new System.Drawing.Font("Arial Black", 17F, System.Drawing.FontStyle.Bold);
            this.dtNascimento.Location = new System.Drawing.Point(1267, 594);
            this.dtNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(743, 47);
            this.dtNascimento.TabIndex = 5;
            this.dtNascimento.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdCliente.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtIdCliente.Location = new System.Drawing.Point(197, 295);
            this.txtIdCliente.MaxLength = 50;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(75, 44);
            this.txtIdCliente.TabIndex = 62;
            this.txtIdCliente.Visible = false;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.lbEmail.ForeColor = System.Drawing.Color.Red;
            this.lbEmail.Location = new System.Drawing.Point(341, 450);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 38);
            this.lbEmail.TabIndex = 63;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.BackColor = System.Drawing.Color.Transparent;
            this.lbCpf.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.lbCpf.ForeColor = System.Drawing.Color.Red;
            this.lbCpf.Location = new System.Drawing.Point(1388, 324);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(0, 38);
            this.lbCpf.TabIndex = 64;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtCidade.Location = new System.Drawing.Point(221, 809);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(813, 44);
            this.txtCidade.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(474, 716);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 48);
            this.label6.TabIndex = 66;
            this.label6.Text = "ENDEREÇO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 805);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 48);
            this.label8.TabIndex = 67;
            this.label8.Text = "CIDADE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1052, 805);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 48);
            this.label9.TabIndex = 69;
            this.label9.Text = "ESTADO";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold);
            this.txtEstado.Location = new System.Drawing.Point(1271, 809);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(725, 44);
            this.txtEstado.TabIndex = 68;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(2034, 980);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.bFechar);
            this.Controls.Add(this.lTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lNumero);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.lNome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.btnFinalizar);
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
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lNome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lTelefone;
        private System.Windows.Forms.Button bFechar;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstado;
    }
}