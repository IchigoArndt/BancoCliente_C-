namespace bancoCliente.Apresentacao.Funcionalidades.Empresas
{
    partial class empresaControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbEmpresa = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.FormattingEnabled = true;
            this.lbEmpresa.Location = new System.Drawing.Point(0, -6);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(686, 329);
            this.lbEmpresa.TabIndex = 0;
            // 
            // empresaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbEmpresa);
            this.Name = "empresaControl";
            this.Size = new System.Drawing.Size(686, 322);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmpresa;
    }
}
