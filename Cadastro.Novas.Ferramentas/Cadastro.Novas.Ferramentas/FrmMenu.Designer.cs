namespace Cadastro.Novas.Ferramentas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.vendasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1444, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.btNovo;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 34);
            this.toolStripMenuItem1.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.btUsuario;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.group_32;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.btClientes;
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.basket;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.btSai3;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarVendasToolStripMenuItem});
            this.vendasToolStripMenuItem.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.finance_32;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(111, 34);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // gerenciarVendasToolStripMenuItem
            // 
            this.gerenciarVendasToolStripMenuItem.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.money_gold;
            this.gerenciarVendasToolStripMenuItem.Name = "gerenciarVendasToolStripMenuItem";
            this.gerenciarVendasToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.gerenciarVendasToolStripMenuItem.Text = "Gerenciar Vendas";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeClientesToolStripMenuItem,
            this.relatórioDeProdutosToolStripMenuItem,
            this.relatórioDeVendasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.btRel;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(136, 34);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioDeClientesToolStripMenuItem
            // 
            this.relatórioDeClientesToolStripMenuItem.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.blueprint2;
            this.relatórioDeClientesToolStripMenuItem.Name = "relatórioDeClientesToolStripMenuItem";
            this.relatórioDeClientesToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.relatórioDeClientesToolStripMenuItem.Text = "Relatório de Clientes";
            // 
            // relatórioDeProdutosToolStripMenuItem
            // 
            this.relatórioDeProdutosToolStripMenuItem.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.blueprint3;
            this.relatórioDeProdutosToolStripMenuItem.Name = "relatórioDeProdutosToolStripMenuItem";
            this.relatórioDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.relatórioDeProdutosToolStripMenuItem.Text = "Relatório de Produtos";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.Image = global::Cadastro.Novas.Ferramentas.Properties.Resources.blueprint4;
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1444, 839);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem gerenciarVendasToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeClientesToolStripMenuItem;
        private ToolStripMenuItem relatórioDeProdutosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}