namespace bancoCliente.Apresentacao.Funcionalidades.Contas
{
    partial class CadastroConta
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
            this.ulblId = new Infragistics.Win.Misc.UltraLabel();
            this.ulblAgencia = new Infragistics.Win.Misc.UltraLabel();
            this.ulblTaxa = new Infragistics.Win.Misc.UltraLabel();
            this.utxtId = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.utxtAgencia = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.utxtTaxa = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.ubtnGravar = new Infragistics.Win.Misc.UltraButton();
            this.ubtCancelar = new Infragistics.Win.Misc.UltraButton();
            this.lblValidacao = new Infragistics.Win.Misc.UltraLabel();
            this.ckbTipoPoupanca = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ckbTipoCorrente = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ckbTipoSalario = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ckbTipoDigital = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ckbTipoPoupanca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbTipoCorrente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbTipoSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbTipoDigital)).BeginInit();
            this.SuspendLayout();
            // 
            // ulblId
            // 
            this.ulblId.Enabled = false;
            this.ulblId.Location = new System.Drawing.Point(13, 12);
            this.ulblId.Name = "ulblId";
            this.ulblId.Size = new System.Drawing.Size(117, 23);
            this.ulblId.TabIndex = 0;
            this.ulblId.Text = "ID";
            // 
            // ulblAgencia
            // 
            this.ulblAgencia.Location = new System.Drawing.Point(13, 53);
            this.ulblAgencia.Name = "ulblAgencia";
            this.ulblAgencia.Size = new System.Drawing.Size(117, 23);
            this.ulblAgencia.TabIndex = 1;
            this.ulblAgencia.Text = "Agência";
            // 
            // ulblTaxa
            // 
            this.ulblTaxa.Location = new System.Drawing.Point(12, 95);
            this.ulblTaxa.Name = "ulblTaxa";
            this.ulblTaxa.Size = new System.Drawing.Size(118, 23);
            this.ulblTaxa.TabIndex = 2;
            this.ulblTaxa.Text = "Taxa de Manutenção";
            // 
            // utxtId
            // 
            this.utxtId.Enabled = false;
            this.utxtId.Location = new System.Drawing.Point(136, 13);
            this.utxtId.Name = "utxtId";
            this.utxtId.Size = new System.Drawing.Size(161, 23);
            this.utxtId.TabIndex = 4;
            this.utxtId.Value = "";
            this.utxtId.Leave += new System.EventHandler(this.utxtId_Leave);
            // 
            // utxtAgencia
            // 
            this.utxtAgencia.Location = new System.Drawing.Point(136, 54);
            this.utxtAgencia.Name = "utxtAgencia";
            this.utxtAgencia.Size = new System.Drawing.Size(161, 23);
            this.utxtAgencia.TabIndex = 5;
            this.utxtAgencia.Value = "";
            this.utxtAgencia.Leave += new System.EventHandler(this.utxtAgencia_Leave);
            // 
            // utxtTaxa
            // 
            this.utxtTaxa.Location = new System.Drawing.Point(136, 95);
            this.utxtTaxa.Name = "utxtTaxa";
            this.utxtTaxa.Size = new System.Drawing.Size(161, 23);
            this.utxtTaxa.TabIndex = 6;
            this.utxtTaxa.Value = "";
            this.utxtTaxa.Leave += new System.EventHandler(this.utxtTaxa_Leave);
            // 
            // ubtnGravar
            // 
            this.ubtnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ubtnGravar.Location = new System.Drawing.Point(13, 210);
            this.ubtnGravar.Name = "ubtnGravar";
            this.ubtnGravar.Size = new System.Drawing.Size(75, 23);
            this.ubtnGravar.TabIndex = 8;
            this.ubtnGravar.Text = "Salvar";
            this.ubtnGravar.Click += new System.EventHandler(this.ubtnGravar_Click);
            // 
            // ubtCancelar
            // 
            this.ubtCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ubtCancelar.Location = new System.Drawing.Point(222, 210);
            this.ubtCancelar.Name = "ubtCancelar";
            this.ubtCancelar.Size = new System.Drawing.Size(75, 23);
            this.ubtCancelar.TabIndex = 9;
            this.ubtCancelar.Text = "Cancelar";
            // 
            // lblValidacao
            // 
            this.lblValidacao.Location = new System.Drawing.Point(94, 210);
            this.lblValidacao.Name = "lblValidacao";
            this.lblValidacao.Size = new System.Drawing.Size(119, 23);
            this.lblValidacao.TabIndex = 11;
            // 
            // ckbTipoPoupanca
            // 
            this.ckbTipoPoupanca.Location = new System.Drawing.Point(13, 144);
            this.ckbTipoPoupanca.Name = "ckbTipoPoupanca";
            this.ckbTipoPoupanca.Size = new System.Drawing.Size(105, 20);
            this.ckbTipoPoupanca.TabIndex = 12;
            this.ckbTipoPoupanca.Text = "Conta Poupança";
            // 
            // ckbTipoCorrente
            // 
            this.ckbTipoCorrente.Location = new System.Drawing.Point(13, 170);
            this.ckbTipoCorrente.Name = "ckbTipoCorrente";
            this.ckbTipoCorrente.Size = new System.Drawing.Size(103, 20);
            this.ckbTipoCorrente.TabIndex = 13;
            this.ckbTipoCorrente.Text = "Conta Corrente";
            // 
            // ckbTipoSalario
            // 
            this.ckbTipoSalario.Location = new System.Drawing.Point(136, 144);
            this.ckbTipoSalario.Name = "ckbTipoSalario";
            this.ckbTipoSalario.Size = new System.Drawing.Size(103, 20);
            this.ckbTipoSalario.TabIndex = 14;
            this.ckbTipoSalario.Text = "Conta Salário";
            // 
            // ckbTipoDigital
            // 
            this.ckbTipoDigital.Location = new System.Drawing.Point(136, 170);
            this.ckbTipoDigital.Name = "ckbTipoDigital";
            this.ckbTipoDigital.Size = new System.Drawing.Size(103, 20);
            this.ckbTipoDigital.TabIndex = 15;
            this.ckbTipoDigital.Text = "Conta Digital";
            // 
            // CadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 237);
            this.Controls.Add(this.ckbTipoDigital);
            this.Controls.Add(this.ckbTipoSalario);
            this.Controls.Add(this.ckbTipoCorrente);
            this.Controls.Add(this.ckbTipoPoupanca);
            this.Controls.Add(this.lblValidacao);
            this.Controls.Add(this.ubtCancelar);
            this.Controls.Add(this.ubtnGravar);
            this.Controls.Add(this.utxtTaxa);
            this.Controls.Add(this.utxtAgencia);
            this.Controls.Add(this.utxtId);
            this.Controls.Add(this.ulblTaxa);
            this.Controls.Add(this.ulblAgencia);
            this.Controls.Add(this.ulblId);
            this.Name = "CadastroConta";
            this.Text = "CadastroConta";
            ((System.ComponentModel.ISupportInitialize)(this.ckbTipoPoupanca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbTipoCorrente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbTipoSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbTipoDigital)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ulblId;
        private Infragistics.Win.Misc.UltraLabel ulblAgencia;
        private Infragistics.Win.Misc.UltraLabel ulblTaxa;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtId;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtAgencia;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtTaxa;
        private Infragistics.Win.Misc.UltraButton ubtnGravar;
        private Infragistics.Win.Misc.UltraButton ubtCancelar;
        private Infragistics.Win.Misc.UltraLabel lblValidacao;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ckbTipoPoupanca;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ckbTipoCorrente;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ckbTipoSalario;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor ckbTipoDigital;
    }
}