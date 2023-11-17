namespace ListaTarefas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtSalario = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNasc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btCadastra = new System.Windows.Forms.Button();
            this.btRegistra = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbSaida = new System.Windows.Forms.GroupBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btSaida = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Funcionario e Ponto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Funcionario";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(72, 119);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(385, 31);
            this.txtNome.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(545, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cargo";
            // 
            // cbCargo
            // 
            this.cbCargo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "1. UX Designer",
            "2. Segurança de Informação",
            "3. Analista de Business Intelligence",
            "4. Suporte técnico",
            "5. Arquitetura de redes",
            "6. Programação",
            "7. Desenvolvedor de software",
            "8. Desenvolvedor de aplicativos"});
            this.cbCargo.Location = new System.Drawing.Point(545, 119);
            this.cbCargo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(249, 31);
            this.cbCargo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(72, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salário";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mtSalario
            // 
            this.mtSalario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtSalario.Location = new System.Drawing.Point(72, 200);
            this.mtSalario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtSalario.Mask = "00.000,00";
            this.mtSalario.Name = "mtSalario";
            this.mtSalario.Size = new System.Drawing.Size(95, 31);
            this.mtSalario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(545, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPF";
            // 
            // mtCPF
            // 
            this.mtCPF.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtCPF.Location = new System.Drawing.Point(545, 209);
            this.mtCPF.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtCPF.Mask = "000.000.000-00";
            this.mtCPF.Name = "mtCPF";
            this.mtCPF.Size = new System.Drawing.Size(150, 31);
            this.mtCPF.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(72, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "TELEFONE";
            // 
            // mtPhone
            // 
            this.mtPhone.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtPhone.Location = new System.Drawing.Point(72, 297);
            this.mtPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtPhone.Mask = "(00)00000-0000";
            this.mtPhone.Name = "mtPhone";
            this.mtPhone.Size = new System.Drawing.Size(159, 31);
            this.mtPhone.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(545, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "DATA NASCIMENTO";
            // 
            // dtNasc
            // 
            this.dtNasc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNasc.Location = new System.Drawing.Point(545, 296);
            this.dtNasc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(139, 32);
            this.dtNasc.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(72, 375);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "DATA DE HOJE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(72, 461);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "HORÁRIO";
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.Location = new System.Drawing.Point(72, 501);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(58, 20);
            this.lblHoraAtual.TabIndex = 17;
            this.lblHoraAtual.Text = "label10";
            this.lblHoraAtual.Click += new System.EventHandler(this.lblHoraAtual_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btCadastra
            // 
            this.btCadastra.Location = new System.Drawing.Point(545, 357);
            this.btCadastra.Name = "btCadastra";
            this.btCadastra.Size = new System.Drawing.Size(115, 39);
            this.btCadastra.TabIndex = 18;
            this.btCadastra.Text = "Cadastrar";
            this.btCadastra.UseVisualStyleBackColor = true;
            this.btCadastra.Click += new System.EventHandler(this.btCadastra_Click);
            // 
            // btRegistra
            // 
            this.btRegistra.Location = new System.Drawing.Point(137, 105);
            this.btRegistra.Name = "btRegistra";
            this.btRegistra.Size = new System.Drawing.Size(122, 39);
            this.btRegistra.TabIndex = 19;
            this.btRegistra.Text = "Entrada";
            this.btRegistra.UseVisualStyleBackColor = true;
            this.btRegistra.Click += new System.EventHandler(this.btRegistra_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(679, 357);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(115, 39);
            this.btLimpar.TabIndex = 20;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEntrada);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btRegistra);
            this.groupBox1.Location = new System.Drawing.Point(352, 438);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 150);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(16, 67);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(0, 20);
            this.lblEntrada.TabIndex = 24;
            this.lblEntrada.Click += new System.EventHandler(this.lblEntrada_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(5, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 30);
            this.label10.TabIndex = 23;
            this.label10.Text = "Registrado";
            // 
            // gbSaida
            // 
            this.gbSaida.Controls.Add(this.lblSaida);
            this.gbSaida.Controls.Add(this.label11);
            this.gbSaida.Controls.Add(this.btSaida);
            this.gbSaida.Location = new System.Drawing.Point(658, 438);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(244, 150);
            this.gbSaida.TabIndex = 22;
            this.gbSaida.TabStop = false;
            this.gbSaida.Text = "Saída";
            this.gbSaida.Enter += new System.EventHandler(this.gbSaida_Enter);
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(14, 67);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(0, 20);
            this.lblSaida.TabIndex = 25;
            this.lblSaida.Click += new System.EventHandler(this.lblSaida_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(5, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 30);
            this.label11.TabIndex = 24;
            this.label11.Text = "Registrado";
            // 
            // btSaida
            // 
            this.btSaida.Location = new System.Drawing.Point(116, 105);
            this.btSaida.Name = "btSaida";
            this.btSaida.Size = new System.Drawing.Size(122, 39);
            this.btSaida.TabIndex = 24;
            this.btSaida.Text = "Saída";
            this.btSaida.UseVisualStyleBackColor = true;
            this.btSaida.Click += new System.EventHandler(this.btSaida_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(72, 422);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(58, 20);
            this.lblData.TabIndex = 23;
            this.lblData.Text = "label10";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(79, 551);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 20);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "label12";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(705, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 20);
            this.lblCodigo.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.gbSaida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastra);
            this.Controls.Add(this.lblHoraAtual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtNasc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Registro de Funcionarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSaida.ResumeLayout(false);
            this.gbSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private Label label4;
        private ComboBox cbCargo;
        private Label label3;
        private MaskedTextBox mtSalario;
        private Label label5;
        private MaskedTextBox mtCPF;
        private Label label6;
        private MaskedTextBox mtPhone;
        private Label label7;
        private DateTimePicker dtNasc;
        private Label label8;
        private Label label9;
        private Label lblHoraAtual;
        private System.Windows.Forms.Timer timer1;
        private Button btCadastra;
        private Button btRegistra;
        private Button btLimpar;
        private GroupBox groupBox1;
        private Label lblEntrada;
        private Label label10;
        private GroupBox gbSaida;
        private Label lblSaida;
        private Label label11;
        private Button btSaida;
        private Label lblData;
        private Label lblStatus;
        private Label lblCodigo;
    }
}