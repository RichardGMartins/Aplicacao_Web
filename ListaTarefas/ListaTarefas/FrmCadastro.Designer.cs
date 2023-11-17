namespace ListaTarefas
{
    partial class FrmCadastro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSalvo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btUpload = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.PictureBox();
            this.dateNasc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSalvo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btSalvar);
            this.groupBox1.Controls.Add(this.btLimpar);
            this.groupBox1.Controls.Add(this.btUpload);
            this.groupBox1.Controls.Add(this.foto);
            this.groupBox1.Controls.Add(this.dateNasc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtCPF);
            this.groupBox1.Controls.Add(this.mtPhone);
            this.groupBox1.Location = new System.Drawing.Point(7, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cadastrais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblSalvo
            // 
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.Location = new System.Drawing.Point(26, 364);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(52, 21);
            this.lblSalvo.TabIndex = 13;
            this.lblSalvo.Text = "label7";
            this.lblSalvo.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(429, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Foto";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(393, 355);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(98, 36);
            this.btSalvar.TabIndex = 11;
            this.btSalvar.Text = "Salvar Tela";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(508, 355);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(95, 33);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(508, 81);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(95, 36);
            this.btUpload.TabIndex = 9;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(387, 123);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(216, 216);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto.TabIndex = 8;
            this.foto.TabStop = false;
            this.foto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateNasc
            // 
            this.dateNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNasc.Location = new System.Drawing.Point(16, 247);
            this.dateNasc.Name = "dateNasc";
            this.dateNasc.Size = new System.Drawing.Size(121, 29);
            this.dateNasc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de nascimento :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(324, 29);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Completo :";
            // 
            // mtCPF
            // 
            this.mtCPF.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtCPF.Location = new System.Drawing.Point(16, 166);
            this.mtCPF.Mask = "000,000,000-00";
            this.mtCPF.Name = "mtCPF";
            this.mtCPF.Size = new System.Drawing.Size(175, 36);
            this.mtCPF.TabIndex = 1;
            // 
            // mtPhone
            // 
            this.mtPhone.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtPhone.Location = new System.Drawing.Point(16, 313);
            this.mtPhone.Mask = "(00)00000-0000";
            this.mtPhone.Name = "mtPhone";
            this.mtPhone.Size = new System.Drawing.Size(143, 36);
            this.mtPhone.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(156, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 46);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cadastro de Usuario";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 522);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox mtPhone;
        private MaskedTextBox mtCPF;
        private PictureBox foto;
        private DateTimePicker dateNasc;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Button btSalvar;
        private Button btLimpar;
        private Button btUpload;
        private Label label5;
        private Label label6;
        private Label lblSalvo;
    }
}