namespace bancoCliente.Apresentacao.Funcionalidades.ClienteJuridico
{
    partial class CJuridicoControl
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
            this.lbCJuridico = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCJuridico
            // 
            this.lbCJuridico.FormattingEnabled = true;
            this.lbCJuridico.Location = new System.Drawing.Point(0, 3);
            this.lbCJuridico.Name = "lbCJuridico";
            this.lbCJuridico.Size = new System.Drawing.Size(372, 329);
            this.lbCJuridico.TabIndex = 0;
            // 
            // CJuridicoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCJuridico);
            this.Name = "CJuridicoControl";
            this.Size = new System.Drawing.Size(372, 332);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCJuridico;
    }
}
