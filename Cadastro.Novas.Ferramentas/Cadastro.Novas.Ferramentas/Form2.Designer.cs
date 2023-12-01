namespace Cadastro.Novas.Ferramentas
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCompl = new System.Windows.Forms.TextBox();
            this.mtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtDTNASC = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnteste = new System.Windows.Forms.Button();
            this.btLimparDados = new System.Windows.Forms.Button();
            this.btExcluirCliente = new System.Windows.Forms.Button();
            this.btAlterarCliente = new System.Windows.Forms.Button();
            this.btNovoCliente = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mtCPF2 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(870, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Endereço :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cidade :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Compl :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "CPF :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(90, 150);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(84, 29);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 191);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(339, 29);
            this.txtNome.TabIndex = 8;
            // 
            // txtEndereço
            // 
            this.txtEndereço.Location = new System.Drawing.Point(103, 233);
            this.txtEndereço.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(318, 29);
            this.txtEndereço.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(87, 279);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(184, 29);
            this.txtCidade.TabIndex = 10;
            // 
            // txtCompl
            // 
            this.txtCompl.Location = new System.Drawing.Point(82, 319);
            this.txtCompl.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(150, 29);
            this.txtCompl.TabIndex = 11;
            // 
            // mtCPF
            // 
            this.mtCPF.Location = new System.Drawing.Point(251, 150);
            this.mtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.mtCPF.Mask = "000,000,000-00";
            this.mtCPF.Name = "mtCPF";
            this.mtCPF.Size = new System.Drawing.Size(135, 29);
            this.mtCPF.TabIndex = 12;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPesquisar.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.srch_32;
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(404, 142);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(118, 37);
            this.btPesquisar.TabIndex = 13;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "N° :";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(467, 233);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(94, 29);
            this.txtNumero.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "CEP :";
            // 
            // mtCEP
            // 
            this.mtCEP.Location = new System.Drawing.Point(320, 279);
            this.mtCEP.Margin = new System.Windows.Forms.Padding(4);
            this.mtCEP.Mask = "00000-000";
            this.mtCEP.Name = "mtCEP";
            this.mtCEP.Size = new System.Drawing.Size(101, 29);
            this.mtCEP.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 283);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "UF :";
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
            this.cbUF.Location = new System.Drawing.Point(472, 280);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(63, 29);
            this.cbUF.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 326);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telefone :";
            // 
            // mtTelefone
            // 
            this.mtTelefone.Location = new System.Drawing.Point(311, 319);
            this.mtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.mtTelefone.Mask = "(00)00000-0000";
            this.mtTelefone.Name = "mtTelefone";
            this.mtTelefone.Size = new System.Drawing.Size(101, 29);
            this.mtTelefone.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(420, 326);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Dt. Nasc :";
            // 
            // mtDTNASC
            // 
            this.mtDTNASC.Location = new System.Drawing.Point(491, 316);
            this.mtDTNASC.Margin = new System.Windows.Forms.Padding(4);
            this.mtDTNASC.Mask = "00/00/0000";
            this.mtDTNASC.Name = "mtDTNASC";
            this.mtDTNASC.Size = new System.Drawing.Size(83, 29);
            this.mtDTNASC.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnteste);
            this.groupBox1.Controls.Add(this.btLimparDados);
            this.groupBox1.Controls.Add(this.btExcluirCliente);
            this.groupBox1.Controls.Add(this.btAlterarCliente);
            this.groupBox1.Controls.Add(this.btNovoCliente);
            this.groupBox1.Location = new System.Drawing.Point(636, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 296);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comandos";
            // 
            // btnteste
            // 
            this.btnteste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnteste.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.ref_32;
            this.btnteste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteste.Location = new System.Drawing.Point(21, 230);
            this.btnteste.Name = "btnteste";
            this.btnteste.Size = new System.Drawing.Size(159, 54);
            this.btnteste.TabIndex = 29;
            this.btnteste.Text = "Teste Conexão";
            this.btnteste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnteste.UseVisualStyleBackColor = true;
            this.btnteste.Click += new System.EventHandler(this.btnteste_Click);
            // 
            // btLimparDados
            // 
            this.btLimparDados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLimparDados.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.paint_tools;
            this.btLimparDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimparDados.Location = new System.Drawing.Point(21, 171);
            this.btLimparDados.Name = "btLimparDados";
            this.btLimparDados.Size = new System.Drawing.Size(159, 54);
            this.btLimparDados.TabIndex = 28;
            this.btLimparDados.Text = "Limpar dados";
            this.btLimparDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimparDados.UseVisualStyleBackColor = true;
            this.btLimparDados.Click += new System.EventHandler(this.button5_Click);
            // 
            // btExcluirCliente
            // 
            this.btExcluirCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btExcluirCliente.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.trash_32;
            this.btExcluirCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluirCliente.Location = new System.Drawing.Point(21, 119);
            this.btExcluirCliente.Name = "btExcluirCliente";
            this.btExcluirCliente.Size = new System.Drawing.Size(159, 47);
            this.btExcluirCliente.TabIndex = 27;
            this.btExcluirCliente.Text = "Excluir Cliente";
            this.btExcluirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // btAlterarCliente
            // 
            this.btAlterarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAlterarCliente.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.btAltera;
            this.btAlterarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterarCliente.Location = new System.Drawing.Point(21, 69);
            this.btAlterarCliente.Name = "btAlterarCliente";
            this.btAlterarCliente.Size = new System.Drawing.Size(159, 44);
            this.btAlterarCliente.TabIndex = 26;
            this.btAlterarCliente.Text = "Alterar Cliente";
            this.btAlterarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // btNovoCliente
            // 
            this.btNovoCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNovoCliente.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.btNovo2;
            this.btNovoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovoCliente.Location = new System.Drawing.Point(21, 23);
            this.btNovoCliente.Name = "btNovoCliente";
            this.btNovoCliente.Size = new System.Drawing.Size(159, 40);
            this.btNovoCliente.TabIndex = 25;
            this.btNovoCliente.Text = "Novo Cliente";
            this.btNovoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNovoCliente.UseVisualStyleBackColor = true;
            this.btNovoCliente.Click += new System.EventHandler(this.btNovoCliente_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 371);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Clientes Cadastrados :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dgCliente
            // 
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Location = new System.Drawing.Point(15, 424);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.RowTemplate.Height = 25;
            this.dgCliente.Size = new System.Drawing.Size(846, 217);
            this.dgCliente.TabIndex = 26;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tpData,
            this.lblData,
            this.tpHora,
            this.toolStripStatusLabel2,
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 649);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Hoje é :";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tpData
            // 
            this.tpData.Name = "tpData";
            this.tpData.Size = new System.Drawing.Size(0, 17);
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(10, 17);
            this.lblData.Text = ".";
            // 
            // tpHora
            // 
            this.tpHora.Name = "tpHora";
            this.tpHora.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel2.Text = "|| e são:";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(10, 17);
            this.lblHora.Text = ".";
            // 
            // mtCPF2
            // 
            this.mtCPF2.Location = new System.Drawing.Point(491, 190);
            this.mtCPF2.Margin = new System.Windows.Forms.Padding(4);
            this.mtCPF2.Mask = "000,000,000-00";
            this.mtCPF2.Name = "mtCPF2";
            this.mtCPF2.Size = new System.Drawing.Size(135, 29);
            this.mtCPF2.TabIndex = 29;
            this.mtCPF2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(439, 194);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 21);
            this.label13.TabIndex = 28;
            this.label13.Text = "CPF :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(870, 671);
            this.Controls.Add(this.mtCPF2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtDTNASC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mtTelefone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mtCEP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.mtCPF);
            this.Controls.Add(this.txtCompl);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtEndereço;
        private TextBox txtCidade;
        private TextBox txtCompl;
        private MaskedTextBox mtCPF;
        private Button btPesquisar;
        private Label label7;
        private TextBox txtNumero;
        private Label label8;
        private MaskedTextBox mtCEP;
        private Label label9;
        private ComboBox cbUF;
        private Label label10;
        private MaskedTextBox mtTelefone;
        private Label label11;
        private MaskedTextBox mtDTNASC;
        private GroupBox groupBox1;
        private Button btLimparDados;
        private Button btExcluirCliente;
        private Button btAlterarCliente;
        private Button btNovoCliente;
        private Label label12;
        private DataGridView dgCliente;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tpData;
        private ToolStripStatusLabel lblData;
        private ToolStripStatusLabel tpHora;
        private System.Windows.Forms.Timer timer1;
        private Button btnteste;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblHora;
        private MaskedTextBox mtCPF2;
        private Label label13;
    }
}