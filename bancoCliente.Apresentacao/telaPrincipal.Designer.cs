namespace bancoCliente.Apresentacao
{
    partial class telaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFisico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJuridica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemConta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastrar = new Infragistics.Win.Misc.UltraButton();
            this.btnExcluir = new Infragistics.Win.Misc.UltraButton();
            this.btnEditar = new Infragistics.Win.Misc.UltraButton();
            this.lblCadastro = new Infragistics.Win.Misc.UltraLabel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.cadastroEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCliente,
            this.tsm,
            this.tsmFuncionario,
            this.cadastroEmpresaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmCliente
            // 
            this.tsmCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFisico,
            this.tsmJuridica});
            this.tsmCliente.Name = "tsmCliente";
            this.tsmCliente.Size = new System.Drawing.Size(106, 20);
            this.tsmCliente.Text = "Cadastro Cliente";
            // 
            // tsmFisico
            // 
            this.tsmFisico.Name = "tsmFisico";
            this.tsmFisico.Size = new System.Drawing.Size(114, 22);
            this.tsmFisico.Text = "Física";
            this.tsmFisico.Click += new System.EventHandler(this.tsmFisico_Click);
            // 
            // tsmJuridica
            // 
            this.tsmJuridica.Name = "tsmJuridica";
            this.tsmJuridica.Size = new System.Drawing.Size(114, 22);
            this.tsmJuridica.Text = "Juridica";
            this.tsmJuridica.Click += new System.EventHandler(this.tsmJuridica_Click);
            // 
            // tsm
            // 
            this.tsm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemConta});
            this.tsm.Name = "tsm";
            this.tsm.Size = new System.Drawing.Size(101, 20);
            this.tsm.Text = "Cadastro Conta";
            // 
            // tsmItemConta
            // 
            this.tsmItemConta.Name = "tsmItemConta";
            this.tsmItemConta.Size = new System.Drawing.Size(180, 22);
            this.tsmItemConta.Text = "Contas";
            this.tsmItemConta.Click += new System.EventHandler(this.tsmItemConta_Click);
            // 
            // tsmFuncionario
            // 
            this.tsmFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemFuncionario});
            this.tsmFuncionario.Name = "tsmFuncionario";
            this.tsmFuncionario.Size = new System.Drawing.Size(132, 20);
            this.tsmFuncionario.Text = "Cadastro Funcionario";
            // 
            // tsmItemFuncionario
            // 
            this.tsmItemFuncionario.Name = "tsmItemFuncionario";
            this.tsmItemFuncionario.Size = new System.Drawing.Size(180, 22);
            this.tsmItemFuncionario.Text = "Funcionario";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 27);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(119, 27);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(86, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(222, 27);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            // 
            // lblCadastro
            // 
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(344, 26);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(321, 23);
            this.lblCadastro.TabIndex = 4;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Location = new System.Drawing.Point(12, 56);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(653, 279);
            this.PanelPrincipal.TabIndex = 5;
            // 
            // cadastroEmpresaToolStripMenuItem
            // 
            this.cadastroEmpresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem});
            this.cadastroEmpresaToolStripMenuItem.Name = "cadastroEmpresaToolStripMenuItem";
            this.cadastroEmpresaToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.cadastroEmpresaToolStripMenuItem.Text = "Cadastro Empresa";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 347);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "telaPrincipal";
            this.Text = "telaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmFisico;
        private System.Windows.Forms.ToolStripMenuItem tsmJuridica;
        private System.Windows.Forms.ToolStripMenuItem tsm;
        private System.Windows.Forms.ToolStripMenuItem tsmItemConta;
        private System.Windows.Forms.ToolStripMenuItem tsmFuncionario;
        private System.Windows.Forms.ToolStripMenuItem tsmItemFuncionario;
        private Infragistics.Win.Misc.UltraButton btnCadastrar;
        private Infragistics.Win.Misc.UltraButton btnExcluir;
        private Infragistics.Win.Misc.UltraButton btnEditar;
        private Infragistics.Win.Misc.UltraLabel lblCadastro;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
    }
}