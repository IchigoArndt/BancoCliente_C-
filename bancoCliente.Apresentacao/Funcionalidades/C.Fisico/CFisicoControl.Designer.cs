namespace bancoCliente.Apresentacao.Funcionalidades.C.Fisico
{
    partial class CFisicoControl
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
            this.lbCFisicoControl = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCFisicoControl
            // 
            this.lbCFisicoControl.FormattingEnabled = true;
            this.lbCFisicoControl.Location = new System.Drawing.Point(4, 4);
            this.lbCFisicoControl.Name = "lbCFisicoControl";
            this.lbCFisicoControl.Size = new System.Drawing.Size(555, 472);
            this.lbCFisicoControl.TabIndex = 0;
            // 
            // CFisicoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCFisicoControl);
            this.Name = "CFisicoControl";
            this.Size = new System.Drawing.Size(559, 476);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCFisicoControl;
    }
}
