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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.ulblId = new Infragistics.Win.Misc.UltraLabel();
            this.ulblAgencia = new Infragistics.Win.Misc.UltraLabel();
            this.ulblTaxa = new Infragistics.Win.Misc.UltraLabel();
            this.ulblTipo = new Infragistics.Win.Misc.UltraLabel();
            this.utxtId = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.utxtAgencia = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.utxtTaxa = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.ucmbTipo = new Infragistics.Win.UltraWinGrid.UltraCombo();
            this.ubtnGravar = new Infragistics.Win.Misc.UltraButton();
            this.ubtCancelar = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.ucmbTipo)).BeginInit();
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
            // ulblTipo
            // 
            this.ulblTipo.Location = new System.Drawing.Point(13, 141);
            this.ulblTipo.Name = "ulblTipo";
            this.ulblTipo.Size = new System.Drawing.Size(117, 23);
            this.ulblTipo.TabIndex = 3;
            this.ulblTipo.Text = "Tipo de Conta";
            // 
            // utxtId
            // 
            this.utxtId.Location = new System.Drawing.Point(136, 13);
            this.utxtId.Name = "utxtId";
            this.utxtId.Size = new System.Drawing.Size(164, 23);
            this.utxtId.TabIndex = 4;
            this.utxtId.Value = "";
            // 
            // utxtAgencia
            // 
            this.utxtAgencia.Location = new System.Drawing.Point(136, 54);
            this.utxtAgencia.Name = "utxtAgencia";
            this.utxtAgencia.Size = new System.Drawing.Size(164, 23);
            this.utxtAgencia.TabIndex = 5;
            this.utxtAgencia.Value = "";
            // 
            // utxtTaxa
            // 
            this.utxtTaxa.Location = new System.Drawing.Point(136, 95);
            this.utxtTaxa.Name = "utxtTaxa";
            this.utxtTaxa.Size = new System.Drawing.Size(164, 23);
            this.utxtTaxa.TabIndex = 6;
            this.utxtTaxa.Value = "";
            // 
            // ucmbTipo
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ucmbTipo.DisplayLayout.Appearance = appearance1;
            this.ucmbTipo.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ucmbTipo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ucmbTipo.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ucmbTipo.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.ucmbTipo.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ucmbTipo.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.ucmbTipo.DisplayLayout.MaxColScrollRegions = 1;
            this.ucmbTipo.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucmbTipo.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ucmbTipo.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ucmbTipo.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ucmbTipo.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.ucmbTipo.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ucmbTipo.DisplayLayout.Override.CellAppearance = appearance8;
            this.ucmbTipo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ucmbTipo.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ucmbTipo.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.ucmbTipo.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ucmbTipo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ucmbTipo.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ucmbTipo.DisplayLayout.Override.RowAppearance = appearance11;
            this.ucmbTipo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucmbTipo.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.ucmbTipo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ucmbTipo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ucmbTipo.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ucmbTipo.Location = new System.Drawing.Point(137, 141);
            this.ucmbTipo.Name = "ucmbTipo";
            this.ucmbTipo.Size = new System.Drawing.Size(163, 22);
            this.ucmbTipo.TabIndex = 7;
            // 
            // ubtnGravar
            // 
            this.ubtnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ubtnGravar.Location = new System.Drawing.Point(44, 185);
            this.ubtnGravar.Name = "ubtnGravar";
            this.ubtnGravar.Size = new System.Drawing.Size(75, 23);
            this.ubtnGravar.TabIndex = 8;
            this.ubtnGravar.Text = "Salvar";
            // 
            // ubtCancelar
            // 
            this.ubtCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ubtCancelar.Location = new System.Drawing.Point(137, 185);
            this.ubtCancelar.Name = "ubtCancelar";
            this.ubtCancelar.Size = new System.Drawing.Size(75, 23);
            this.ubtCancelar.TabIndex = 9;
            this.ubtCancelar.Text = "Cancelar";
            // 
            // CadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 219);
            this.Controls.Add(this.ubtCancelar);
            this.Controls.Add(this.ubtnGravar);
            this.Controls.Add(this.ucmbTipo);
            this.Controls.Add(this.utxtTaxa);
            this.Controls.Add(this.utxtAgencia);
            this.Controls.Add(this.utxtId);
            this.Controls.Add(this.ulblTipo);
            this.Controls.Add(this.ulblTaxa);
            this.Controls.Add(this.ulblAgencia);
            this.Controls.Add(this.ulblId);
            this.Name = "CadastroConta";
            this.Text = "CadastroConta";
            ((System.ComponentModel.ISupportInitialize)(this.ucmbTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ulblId;
        private Infragistics.Win.Misc.UltraLabel ulblAgencia;
        private Infragistics.Win.Misc.UltraLabel ulblTaxa;
        private Infragistics.Win.Misc.UltraLabel ulblTipo;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtId;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtAgencia;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtTaxa;
        private Infragistics.Win.UltraWinGrid.UltraCombo ucmbTipo;
        private Infragistics.Win.Misc.UltraButton ubtnGravar;
        private Infragistics.Win.Misc.UltraButton ubtCancelar;
    }
}