namespace bancoCliente.Apresentacao.Funcionalidades.Funcionario
{
    partial class funcionarioControl
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
            this.lbFuncionario = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbFuncionario
            // 
            this.lbFuncionario.FormattingEnabled = true;
            this.lbFuncionario.Location = new System.Drawing.Point(0, -2);
            this.lbFuncionario.Name = "lbFuncionario";
            this.lbFuncionario.Size = new System.Drawing.Size(340, 355);
            this.lbFuncionario.TabIndex = 0;
            // 
            // funcionarioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbFuncionario);
            this.Name = "funcionarioControl";
            this.Size = new System.Drawing.Size(343, 350);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFuncionario;
    }
}
