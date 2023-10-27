namespace Projeto_Salvar_Senhas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listSenhas = new System.Windows.Forms.ListBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA SALVAR SENHAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME DO SITE :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(7, 260);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(355, 29);
            this.txtSite.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "USUÁRIO/E-MAIL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(7, 316);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(355, 29);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "SENHA:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(7, 372);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(355, 29);
            this.txtSenha.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "SALVAR DADOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 480);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 21);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "INFORMAÇÕES SALVAS NO ARQUIVOS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // listSenhas
            // 
            this.listSenhas.FormattingEnabled = true;
            this.listSenhas.ItemHeight = 21;
            this.listSenhas.Location = new System.Drawing.Point(12, 539);
            this.listSenhas.Name = "listSenhas";
            this.listSenhas.Size = new System.Drawing.Size(277, 130);
            this.listSenhas.TabIndex = 11;
            this.listSenhas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(308, 539);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 37);
            this.btnExibir.TabIndex = 12;
            this.btnExibir.Text = "EXIBIR";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(405, 688);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.listSenhas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sistem salva senhas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSite;
        private Label label3;
        private TextBox txtUsuario;
        private Label label4;
        private TextBox txtSenha;
        private Button button1;
        private Button button2;
        private Label lblStatus;
        private Label label6;
        private ListBox listSenhas;
        private Button btnExibir;
        private PictureBox pictureBox1;
    }
}