namespace bancoCliente.Apresentacao.Funcionalidades.Contas
{
    partial class ContaControl
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
            this.lbConta = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbConta
            // 
            this.lbConta.FormattingEnabled = true;
            this.lbConta.Location = new System.Drawing.Point(4, 4);
            this.lbConta.Name = "lbConta";
            this.lbConta.Size = new System.Drawing.Size(413, 329);
            this.lbConta.TabIndex = 0;
            // 
            // ContaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbConta);
            this.Name = "ContaControl";
            this.Size = new System.Drawing.Size(420, 331);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbConta;
    }
}
