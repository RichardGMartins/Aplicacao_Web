namespace ProjetoCalculaFrete
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblValTotal = new System.Windows.Forms.Label();
            this.lblValProf = new System.Windows.Forms.Label();
            this.lblValTransp = new System.Windows.Forms.Label();
            this.lblValUF = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPROFISSIONAIS = new System.Windows.Forms.ComboBox();
            this.cbTransporte = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtAvista = new System.Windows.Forms.TextBox();
            this.cbCredito = new System.Windows.Forms.ComboBox();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbAvista = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUF);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.txtOrigem);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(26, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbUF
            // 
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "GO",
            "ES",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SP",
            "SC",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(537, 137);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(121, 33);
            this.cbUF.TabIndex = 7;
            this.cbUF.SelectedIndexChanged += new System.EventHandler(this.cbUF_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "UF :";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(215, 138);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(267, 32);
            this.txtDestino.TabIndex = 5;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(215, 92);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(267, 32);
            this.txtOrigem.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(215, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 32);
            this.txtNome.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "CIDADE DESTINO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "CIDADE DE ORIGEM :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "NOME DO CLIENTE : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATA :";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(503, 20);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 25);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "label2";
            this.lblData.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(360, 32);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDesc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblValTotal);
            this.groupBox2.Controls.Add(this.lblValProf);
            this.groupBox2.Controls.Add(this.lblValTransp);
            this.groupBox2.Controls.Add(this.lblValUF);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbPROFISSIONAIS);
            this.groupBox2.Controls.Add(this.cbTransporte);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(26, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 328);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DADOS DO FRETE";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(147, 288);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(73, 25);
            this.lblDesc.TabIndex = 20;
            this.lblDesc.Text = "label16";
            this.lblDesc.Click += new System.EventHandler(this.label13_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "15% DESC :";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "LIMPAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(497, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "CONCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblValTotal
            // 
            this.lblValTotal.AutoSize = true;
            this.lblValTotal.Location = new System.Drawing.Point(167, 250);
            this.lblValTotal.Name = "lblValTotal";
            this.lblValTotal.Size = new System.Drawing.Size(73, 25);
            this.lblValTotal.TabIndex = 17;
            this.lblValTotal.Text = "label16";
            // 
            // lblValProf
            // 
            this.lblValProf.AutoSize = true;
            this.lblValProf.Location = new System.Drawing.Point(260, 211);
            this.lblValProf.Name = "lblValProf";
            this.lblValProf.Size = new System.Drawing.Size(73, 25);
            this.lblValProf.TabIndex = 16;
            this.lblValProf.Text = "label15";
            // 
            // lblValTransp
            // 
            this.lblValTransp.AutoSize = true;
            this.lblValTransp.Location = new System.Drawing.Point(260, 175);
            this.lblValTransp.Name = "lblValTransp";
            this.lblValTransp.Size = new System.Drawing.Size(73, 25);
            this.lblValTransp.TabIndex = 15;
            this.lblValTransp.Text = "label14";
            // 
            // lblValUF
            // 
            this.lblValUF.AutoSize = true;
            this.lblValUF.Location = new System.Drawing.Point(147, 135);
            this.lblValUF.Name = "lblValUF";
            this.lblValUF.Size = new System.Drawing.Size(73, 25);
            this.lblValUF.TabIndex = 14;
            this.lblValUF.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "VALOR TOTAL :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(212, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "VALOR PROFISSIONAIS :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "VALOR DO TRANSPORTE :";
            // 
            // cbPROFISSIONAIS
            // 
            this.cbPROFISSIONAIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPROFISSIONAIS.FormattingEnabled = true;
            this.cbPROFISSIONAIS.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.cbPROFISSIONAIS.Location = new System.Drawing.Point(355, 73);
            this.cbPROFISSIONAIS.Name = "cbPROFISSIONAIS";
            this.cbPROFISSIONAIS.Size = new System.Drawing.Size(87, 33);
            this.cbPROFISSIONAIS.TabIndex = 9;
            this.cbPROFISSIONAIS.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cbTransporte
            // 
            this.cbTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransporte.FormattingEnabled = true;
            this.cbTransporte.Items.AddRange(new object[] {
            "P",
            "M",
            "G"});
            this.cbTransporte.Location = new System.Drawing.Point(398, 28);
            this.cbTransporte.Name = "cbTransporte";
            this.cbTransporte.Size = new System.Drawing.Size(84, 33);
            this.cbTransporte.TabIndex = 8;
            this.cbTransporte.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "VALOR UF :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "ESCOLHA A QTD DE PROFISSIONAIS :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "ESCOLHA O TAMANHO DO TRANSPORTE :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCredito);
            this.groupBox4.Controls.Add(this.txtAvista);
            this.groupBox4.Controls.Add(this.cbCredito);
            this.groupBox4.Controls.Add(this.rbCredito);
            this.groupBox4.Controls.Add(this.rbAvista);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(26, 606);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(753, 145);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TIPOS DE PAGAMENTOS";
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(472, 91);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(152, 32);
            this.txtCredito.TabIndex = 19;
            // 
            // txtAvista
            // 
            this.txtAvista.Location = new System.Drawing.Point(122, 41);
            this.txtAvista.Name = "txtAvista";
            this.txtAvista.Size = new System.Drawing.Size(169, 32);
            this.txtAvista.TabIndex = 8;
            // 
            // cbCredito
            // 
            this.cbCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCredito.FormattingEnabled = true;
            this.cbCredito.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbCredito.Location = new System.Drawing.Point(472, 42);
            this.cbCredito.Name = "cbCredito";
            this.cbCredito.Size = new System.Drawing.Size(152, 33);
            this.cbCredito.TabIndex = 18;
            this.cbCredito.SelectedIndexChanged += new System.EventHandler(this.cbCredito_SelectedIndexChanged);
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Location = new System.Drawing.Point(355, 42);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(108, 29);
            this.rbCredito.TabIndex = 1;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "CRÉDITO";
            this.rbCredito.UseVisualStyleBackColor = true;
            this.rbCredito.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbAvista
            // 
            this.rbAvista.AutoSize = true;
            this.rbAvista.Location = new System.Drawing.Point(21, 42);
            this.rbAvista.Name = "rbAvista";
            this.rbAvista.Size = new System.Drawing.Size(101, 29);
            this.rbAvista.TabIndex = 0;
            this.rbAvista.TabStop = true;
            this.rbAvista.Text = "Á VISTA";
            this.rbAvista.UseVisualStyleBackColor = true;
            this.rbAvista.CheckedChanged += new System.EventHandler(this.rbAvista_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 795);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calcula Frete";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtDestino;
        private TextBox txtOrigem;
        private TextBox txtNome;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lblData;
        private ComboBox cbUF;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private ComboBox cbPROFISSIONAIS;
        private ComboBox cbTransporte;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lblValTotal;
        private Label lblValProf;
        private Label lblValTransp;
        private Label lblValUF;
        private Label label12;
        private Label label11;
        private Label label10;
        private GroupBox groupBox4;
        private RadioButton rbCredito;
        private RadioButton rbAvista;
        private TextBox txtCredito;
        private TextBox txtAvista;
        private ComboBox cbCredito;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblDesc;
    }
}