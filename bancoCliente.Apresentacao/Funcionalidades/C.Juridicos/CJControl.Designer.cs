﻿namespace bancoCliente.Apresentacao.Funcionalidades.ClientesJuridicos
{
    partial class CJControl
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
            this.lbCJ = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCJ
            // 
            this.lbCJ.FormattingEnabled = true;
            this.lbCJ.Location = new System.Drawing.Point(0, 0);
            this.lbCJ.Name = "lbCJ";
            this.lbCJ.Size = new System.Drawing.Size(686, 329);
            this.lbCJ.TabIndex = 0;
            this.lbCJ.SelectedIndexChanged += new System.EventHandler(this.lbCJ_SelectedIndexChanged);
            // 
            // CJControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCJ);
            this.Name = "CJControl";
            this.Size = new System.Drawing.Size(686, 329);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCJ;
    }
}
