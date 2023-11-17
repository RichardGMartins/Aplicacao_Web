namespace ListaTarefas
{
    partial class FrmTarefas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTarefas));
            this.label1 = new System.Windows.Forms.Label();
            this.Horas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDataLimite = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.listTarefas = new System.Windows.Forms.ListBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExibir = new System.Windows.Forms.Button();
            this.txtTarefas = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSalvo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data de Hoje :";
            // 
            // Horas
            // 
            this.Horas.AutoSize = true;
            this.Horas.Location = new System.Drawing.Point(25, 317);
            this.Horas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Horas.Name = "Horas";
            this.Horas.Size = new System.Drawing.Size(70, 25);
            this.Horas.TabIndex = 2;
            this.Horas.Text = "Horas :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarefas :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 452);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Limite :";
            // 
            // dtDataLimite
            // 
            this.dtDataLimite.Location = new System.Drawing.Point(25, 489);
            this.dtDataLimite.Margin = new System.Windows.Forms.Padding(2);
            this.dtDataLimite.Name = "dtDataLimite";
            this.dtDataLimite.Size = new System.Drawing.Size(383, 32);
            this.dtDataLimite.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(138, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lista de Tarefas";
            // 
            // listTarefas
            // 
            this.listTarefas.FormattingEnabled = true;
            this.listTarefas.ItemHeight = 25;
            this.listTarefas.Location = new System.Drawing.Point(4, 591);
            this.listTarefas.Margin = new System.Windows.Forms.Padding(2);
            this.listTarefas.Name = "listTarefas";
            this.listTarefas.Size = new System.Drawing.Size(434, 104);
            this.listTarefas.TabIndex = 9;
            this.listTarefas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(245, 544);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(90, 32);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExibir
            // 
            this.btExibir.Location = new System.Drawing.Point(339, 708);
            this.btExibir.Margin = new System.Windows.Forms.Padding(2);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(90, 32);
            this.btExibir.TabIndex = 11;
            this.btExibir.Text = "Exibir";
            this.btExibir.UseVisualStyleBackColor = true;
            this.btExibir.Click += new System.EventHandler(this.btExibir_Click);
            // 
            // txtTarefas
            // 
            this.txtTarefas.Location = new System.Drawing.Point(25, 405);
            this.txtTarefas.Margin = new System.Windows.Forms.Padding(2);
            this.txtTarefas.Name = "txtTarefas";
            this.txtTarefas.Size = new System.Drawing.Size(383, 32);
            this.txtTarefas.TabIndex = 12;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(339, 544);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(90, 32);
            this.btLimpar.TabIndex = 16;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(168, 263);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 25);
            this.lblData.TabIndex = 17;
            this.lblData.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(114, 317);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(63, 25);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSalvo
            // 
            this.lblSalvo.AutoSize = true;
            this.lblSalvo.Location = new System.Drawing.Point(39, 547);
            this.lblSalvo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalvo.Name = "lblSalvo";
            this.lblSalvo.Size = new System.Drawing.Size(63, 25);
            this.lblSalvo.TabIndex = 19;
            this.lblSalvo.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSalvo);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.txtTarefas);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.listTarefas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtDataLimite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Horas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lista de Tarefas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label Horas;
        private Label label3;
        private Label label4;
        private DateTimePicker dtDataLimite;
        private Label label5;
        private ListBox listTarefas;
        private Button btSalvar;
        private Button btExibir;
        private TextBox txtTarefas;
        private Button btLimpar;
        private Label lblData;
        private Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Label lblSalvo;
        private PictureBox pictureBox1;
    }
}