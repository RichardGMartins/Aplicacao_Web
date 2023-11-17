namespace Cadastro.Novas.Ferramentas
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.dtNasc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btVisu = new System.Windows.Forms.Button();
            this.btAbrirArquivos = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btSelecionarP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIdade);
            this.groupBox1.Controls.Add(this.dtNasc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(705, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS CADASTRAIS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(393, 170);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(52, 21);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "label4";
            this.lblIdade.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtNasc
            // 
            this.dtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNasc.Location = new System.Drawing.Point(237, 161);
            this.dtNasc.Margin = new System.Windows.Forms.Padding(4);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(130, 29);
            this.dtNasc.TabIndex = 5;
            this.dtNasc.ValueChanged += new System.EventHandler(this.dtNasc_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "DATA DE NASCIMENTO : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 105);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(454, 29);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(121, 41);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(454, 29);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-MAIL :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME :";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btVisu
            // 
            this.btVisu.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.Zoom;
            this.btVisu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVisu.Location = new System.Drawing.Point(32, 274);
            this.btVisu.Margin = new System.Windows.Forms.Padding(4);
            this.btVisu.Name = "btVisu";
            this.btVisu.Size = new System.Drawing.Size(147, 59);
            this.btVisu.TabIndex = 1;
            this.btVisu.Text = "VISUALIZAR";
            this.btVisu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVisu.UseVisualStyleBackColor = true;
            this.btVisu.Click += new System.EventHandler(this.btVisu_Click);
            // 
            // btAbrirArquivos
            // 
            this.btAbrirArquivos.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.Folder;
            this.btAbrirArquivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAbrirArquivos.Location = new System.Drawing.Point(277, 274);
            this.btAbrirArquivos.Margin = new System.Windows.Forms.Padding(4);
            this.btAbrirArquivos.Name = "btAbrirArquivos";
            this.btAbrirArquivos.Size = new System.Drawing.Size(194, 59);
            this.btAbrirArquivos.TabIndex = 2;
            this.btAbrirArquivos.Text = "ABRIR ARQUIVOS";
            this.btAbrirArquivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAbrirArquivos.UseVisualStyleBackColor = true;
            this.btAbrirArquivos.Click += new System.EventHandler(this.btAbrirArquivos_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.Folder_downloads;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(535, 274);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(132, 59);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.Printer_modern;
            this.btImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImprimir.Location = new System.Drawing.Point(32, 352);
            this.btImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(140, 59);
            this.btImprimir.TabIndex = 5;
            this.btImprimir.Text = "IMPRIMIR";
            this.btImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btSelecionarP
            // 
            this.btSelecionarP.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.Folder_docs;
            this.btSelecionarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSelecionarP.Location = new System.Drawing.Point(277, 352);
            this.btSelecionarP.Margin = new System.Windows.Forms.Padding(4);
            this.btSelecionarP.Name = "btSelecionarP";
            this.btSelecionarP.Size = new System.Drawing.Size(209, 59);
            this.btSelecionarP.TabIndex = 6;
            this.btSelecionarP.Text = "SELECIONAR PASTA";
            this.btSelecionarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSelecionarP.UseVisualStyleBackColor = true;
            this.btSelecionarP.Click += new System.EventHandler(this.btSelecionarP_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 471);
            this.Controls.Add(this.btSelecionarP);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btAbrirArquivos);
            this.Controls.Add(this.btVisu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtNasc;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btVisu;
        private Button btAbrirArquivos;
        private Button btSalvar;
        private Button btImprimir;
        private Button btSelecionarP;
        private Label lblIdade;
    }
}