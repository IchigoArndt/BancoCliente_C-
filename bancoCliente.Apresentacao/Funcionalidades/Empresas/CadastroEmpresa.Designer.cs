namespace bancoCliente.Apresentacao.Funcionalidades.Empresas
{
    partial class CadastroEmpresa
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
            this.utxtID = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.utxtRazao = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.ulblRazao = new Infragistics.Win.Misc.UltraLabel();
            this.utxtNome = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.utxtCNPJ = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.utxtTelefone = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.utxtEmail = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.uPanelEndereco = new Infragistics.Win.Misc.UltraPanel();
            this.ucmbUf = new System.Windows.Forms.ComboBox();
            this.utxtComplemento = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtCidade = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtBairro = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.utxtRua = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtNumero = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
            this.btnGravar = new Infragistics.Win.Misc.UltraButton();
            this.utxtSair = new Infragistics.Win.Misc.UltraButton();
            this.panelFuncionarios = new Infragistics.Win.Misc.UltraPanel();
            this.lbFunc = new System.Windows.Forms.ListBox();
            this.lbFuncCadastrado = new System.Windows.Forms.ListBox();
            this.btnDeletar = new Infragistics.Win.Misc.UltraButton();
            this.btnAdcFunc = new Infragistics.Win.Misc.UltraButton();
            this.lblValidacao = new Infragistics.Win.Misc.UltraLabel();
            this.dtFund = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.uPanelEndereco.ClientArea.SuspendLayout();
            this.uPanelEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utxtComplemento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtBairro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtRua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtNumero)).BeginInit();
            this.panelFuncionarios.ClientArea.SuspendLayout();
            this.panelFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFund)).BeginInit();
            this.SuspendLayout();
            // 
            // ulblId
            // 
            this.ulblId.Location = new System.Drawing.Point(13, 13);
            this.ulblId.Name = "ulblId";
            this.ulblId.Size = new System.Drawing.Size(66, 23);
            this.ulblId.TabIndex = 0;
            this.ulblId.Text = "ID:";
            this.ulblId.Click += new System.EventHandler(this.ultraLabel1_Click);
            // 
            // utxtID
            // 
            this.utxtID.Enabled = false;
            this.utxtID.Location = new System.Drawing.Point(125, 12);
            this.utxtID.Name = "utxtID";
            this.utxtID.Size = new System.Drawing.Size(164, 23);
            this.utxtID.TabIndex = 3;
            this.utxtID.Value = "";
            this.utxtID.LinkClicked += new Infragistics.Win.FormattedLinkLabel.LinkClickedEventHandler(this.ultraFormattedTextEditor1_LinkClicked);
            // 
            // utxtRazao
            // 
            this.utxtRazao.Location = new System.Drawing.Point(391, 12);
            this.utxtRazao.Name = "utxtRazao";
            this.utxtRazao.Size = new System.Drawing.Size(164, 23);
            this.utxtRazao.TabIndex = 5;
            this.utxtRazao.Value = "";
            this.utxtRazao.Leave += new System.EventHandler(this.utxtNome_ValueChanged);
            // 
            // ulblRazao
            // 
            this.ulblRazao.Location = new System.Drawing.Point(307, 14);
            this.ulblRazao.Name = "ulblRazao";
            this.ulblRazao.Size = new System.Drawing.Size(78, 23);
            this.ulblRazao.TabIndex = 4;
            this.ulblRazao.Text = "Razão Social";
            // 
            // utxtNome
            // 
            this.utxtNome.Location = new System.Drawing.Point(125, 58);
            this.utxtNome.Name = "utxtNome";
            this.utxtNome.Size = new System.Drawing.Size(164, 23);
            this.utxtNome.TabIndex = 7;
            this.utxtNome.Value = "";
            this.utxtNome.Leave += new System.EventHandler(this.utxtNome_ValueChanged);
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(13, 58);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(88, 23);
            this.ultraLabel3.TabIndex = 6;
            this.ultraLabel3.Text = "Nome Fantasia";
            // 
            // utxtCNPJ
            // 
            this.utxtCNPJ.Location = new System.Drawing.Point(391, 59);
            this.utxtCNPJ.Name = "utxtCNPJ";
            this.utxtCNPJ.Size = new System.Drawing.Size(164, 23);
            this.utxtCNPJ.TabIndex = 9;
            this.utxtCNPJ.Value = "";
            this.utxtCNPJ.Leave += new System.EventHandler(this.utxtCnpj_leave);
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Location = new System.Drawing.Point(307, 61);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(78, 23);
            this.ultraLabel4.TabIndex = 8;
            this.ultraLabel4.Text = "CNPJ:";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Location = new System.Drawing.Point(9, 103);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(99, 23);
            this.ultraLabel5.TabIndex = 10;
            this.ultraLabel5.Text = "Data de Fundação";
            // 
            // utxtTelefone
            // 
            this.utxtTelefone.Location = new System.Drawing.Point(391, 104);
            this.utxtTelefone.Name = "utxtTelefone";
            this.utxtTelefone.Size = new System.Drawing.Size(164, 23);
            this.utxtTelefone.TabIndex = 13;
            this.utxtTelefone.Value = "";
            this.utxtTelefone.Leave += new System.EventHandler(this.utxtTel_Leave);
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Location = new System.Drawing.Point(307, 106);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(78, 23);
            this.ultraLabel6.TabIndex = 12;
            this.ultraLabel6.Text = "Telefone";
            // 
            // utxtEmail
            // 
            this.utxtEmail.Location = new System.Drawing.Point(125, 142);
            this.utxtEmail.Name = "utxtEmail";
            this.utxtEmail.Size = new System.Drawing.Size(164, 23);
            this.utxtEmail.TabIndex = 15;
            this.utxtEmail.Value = "";
            this.utxtEmail.Leave += new System.EventHandler(this.utxtEmail_Leave);
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.Location = new System.Drawing.Point(9, 142);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(78, 23);
            this.ultraLabel7.TabIndex = 14;
            this.ultraLabel7.Text = "Email";
            // 
            // uPanelEndereco
            // 
            // 
            // uPanelEndereco.ClientArea
            // 
            this.uPanelEndereco.ClientArea.Controls.Add(this.ucmbUf);
            this.uPanelEndereco.ClientArea.Controls.Add(this.utxtComplemento);
            this.uPanelEndereco.ClientArea.Controls.Add(this.utxtCidade);
            this.uPanelEndereco.ClientArea.Controls.Add(this.utxtBairro);
            this.uPanelEndereco.ClientArea.Controls.Add(this.ultraLabel1);
            this.uPanelEndereco.ClientArea.Controls.Add(this.ultraLabel2);
            this.uPanelEndereco.ClientArea.Controls.Add(this.utxtRua);
            this.uPanelEndereco.ClientArea.Controls.Add(this.utxtNumero);
            this.uPanelEndereco.ClientArea.Controls.Add(this.ultraLabel8);
            this.uPanelEndereco.ClientArea.Controls.Add(this.ultraLabel9);
            this.uPanelEndereco.ClientArea.Controls.Add(this.ultraLabel10);
            this.uPanelEndereco.ClientArea.Controls.Add(this.ultraLabel11);
            this.uPanelEndereco.Location = new System.Drawing.Point(9, 184);
            this.uPanelEndereco.Name = "uPanelEndereco";
            this.uPanelEndereco.Size = new System.Drawing.Size(556, 102);
            this.uPanelEndereco.TabIndex = 16;
            // 
            // ucmbUf
            // 
            this.ucmbUf.FormattingEnabled = true;
            this.ucmbUf.Location = new System.Drawing.Point(382, 68);
            this.ucmbUf.Name = "ucmbUf";
            this.ucmbUf.Size = new System.Drawing.Size(164, 21);
            this.ucmbUf.TabIndex = 21;
            this.ucmbUf.SelectedIndexChanged += new System.EventHandler(this.ucmbUf_SelectedIndexChanged);
            // 
            // utxtComplemento
            // 
            this.utxtComplemento.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.utxtComplemento.Location = new System.Drawing.Point(116, 36);
            this.utxtComplemento.Name = "utxtComplemento";
            this.utxtComplemento.Size = new System.Drawing.Size(164, 19);
            this.utxtComplemento.TabIndex = 20;
            this.utxtComplemento.Leave += new System.EventHandler(this.utxtComplemento_Leave);
            // 
            // utxtCidade
            // 
            this.utxtCidade.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.utxtCidade.Location = new System.Drawing.Point(116, 65);
            this.utxtCidade.Name = "utxtCidade";
            this.utxtCidade.Size = new System.Drawing.Size(164, 19);
            this.utxtCidade.TabIndex = 18;
            this.utxtCidade.Leave += new System.EventHandler(this.utxtCidade_Leave);
            // 
            // utxtBairro
            // 
            this.utxtBairro.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.utxtBairro.Location = new System.Drawing.Point(382, 42);
            this.utxtBairro.Name = "utxtBairro";
            this.utxtBairro.Size = new System.Drawing.Size(164, 19);
            this.utxtBairro.TabIndex = 17;
            this.utxtBairro.Leave += new System.EventHandler(this.utxtBairro_Leave);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraLabel1.Location = new System.Drawing.Point(298, 67);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(70, 23);
            this.ultraLabel1.TabIndex = 16;
            this.ultraLabel1.Text = "Estado:";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraLabel2.Location = new System.Drawing.Point(4, 61);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(67, 23);
            this.ultraLabel2.TabIndex = 15;
            this.ultraLabel2.Text = "Cidade:";
            // 
            // utxtRua
            // 
            this.utxtRua.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.utxtRua.Location = new System.Drawing.Point(116, 11);
            this.utxtRua.Name = "utxtRua";
            this.utxtRua.Size = new System.Drawing.Size(164, 19);
            this.utxtRua.TabIndex = 14;
            this.utxtRua.Leave += new System.EventHandler(this.utxtRua_Leave);
            // 
            // utxtNumero
            // 
            this.utxtNumero.BorderStyle = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.utxtNumero.Location = new System.Drawing.Point(382, 11);
            this.utxtNumero.Name = "utxtNumero";
            this.utxtNumero.Size = new System.Drawing.Size(164, 19);
            this.utxtNumero.TabIndex = 8;
            this.utxtNumero.Leave += new System.EventHandler(this.utxtNumero_Leave);
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraLabel8.Location = new System.Drawing.Point(298, 38);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(66, 23);
            this.ultraLabel8.TabIndex = 11;
            this.ultraLabel8.Text = "Bairro:";
            // 
            // ultraLabel9
            // 
            this.ultraLabel9.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraLabel9.Location = new System.Drawing.Point(4, 3);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.Size = new System.Drawing.Size(66, 23);
            this.ultraLabel9.TabIndex = 8;
            this.ultraLabel9.Text = "Rua:";
            // 
            // ultraLabel10
            // 
            this.ultraLabel10.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraLabel10.Location = new System.Drawing.Point(4, 32);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.Size = new System.Drawing.Size(83, 23);
            this.ultraLabel10.TabIndex = 10;
            this.ultraLabel10.Text = "Complemento:";
            // 
            // ultraLabel11
            // 
            this.ultraLabel11.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraLabel11.Location = new System.Drawing.Point(298, 7);
            this.ultraLabel11.Name = "ultraLabel11";
            this.ultraLabel11.Size = new System.Drawing.Size(67, 23);
            this.ultraLabel11.TabIndex = 9;
            this.ultraLabel11.Text = "Numero:";
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(12, 461);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(162, 23);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // utxtSair
            // 
            this.utxtSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.utxtSair.Location = new System.Drawing.Point(393, 461);
            this.utxtSair.Name = "utxtSair";
            this.utxtSair.Size = new System.Drawing.Size(162, 23);
            this.utxtSair.TabIndex = 18;
            this.utxtSair.Text = "Sair";
            // 
            // panelFuncionarios
            // 
            // 
            // panelFuncionarios.ClientArea
            // 
            this.panelFuncionarios.ClientArea.Controls.Add(this.lbFunc);
            this.panelFuncionarios.ClientArea.Controls.Add(this.lbFuncCadastrado);
            this.panelFuncionarios.ClientArea.Controls.Add(this.btnDeletar);
            this.panelFuncionarios.ClientArea.Controls.Add(this.btnAdcFunc);
            this.panelFuncionarios.Location = new System.Drawing.Point(13, 292);
            this.panelFuncionarios.Name = "panelFuncionarios";
            this.panelFuncionarios.Size = new System.Drawing.Size(542, 163);
            this.panelFuncionarios.TabIndex = 21;
            // 
            // lbFunc
            // 
            this.lbFunc.FormattingEnabled = true;
            this.lbFunc.Location = new System.Drawing.Point(294, 29);
            this.lbFunc.Name = "lbFunc";
            this.lbFunc.Size = new System.Drawing.Size(248, 134);
            this.lbFunc.TabIndex = 4;
            // 
            // lbFuncCadastrado
            // 
            this.lbFuncCadastrado.FormattingEnabled = true;
            this.lbFuncCadastrado.Location = new System.Drawing.Point(0, 29);
            this.lbFuncCadastrado.Name = "lbFuncCadastrado";
            this.lbFuncCadastrado.Size = new System.Drawing.Size(283, 134);
            this.lbFuncCadastrado.TabIndex = 3;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(459, 3);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAdcFunc
            // 
            this.btnAdcFunc.Location = new System.Drawing.Point(3, 3);
            this.btnAdcFunc.Name = "btnAdcFunc";
            this.btnAdcFunc.Size = new System.Drawing.Size(75, 23);
            this.btnAdcFunc.TabIndex = 0;
            this.btnAdcFunc.Text = "Adicionar";
            this.btnAdcFunc.Click += new System.EventHandler(this.btnAdcFunc_Click);
            // 
            // lblValidacao
            // 
            this.lblValidacao.Location = new System.Drawing.Point(180, 461);
            this.lblValidacao.Name = "lblValidacao";
            this.lblValidacao.Size = new System.Drawing.Size(207, 22);
            this.lblValidacao.TabIndex = 23;
            // 
            // dtFund
            // 
            this.dtFund.Location = new System.Drawing.Point(125, 104);
            this.dtFund.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtFund.Name = "dtFund";
            this.dtFund.Size = new System.Drawing.Size(164, 21);
            this.dtFund.TabIndex = 24;
            this.dtFund.Leave += new System.EventHandler(this.dtFund_Leave);
            // 
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 496);
            this.Controls.Add(this.dtFund);
            this.Controls.Add(this.lblValidacao);
            this.Controls.Add(this.panelFuncionarios);
            this.Controls.Add(this.utxtSair);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.uPanelEndereco);
            this.Controls.Add(this.utxtEmail);
            this.Controls.Add(this.ultraLabel7);
            this.Controls.Add(this.utxtTelefone);
            this.Controls.Add(this.ultraLabel6);
            this.Controls.Add(this.ultraLabel5);
            this.Controls.Add(this.utxtCNPJ);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.utxtNome);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.utxtRazao);
            this.Controls.Add(this.ulblRazao);
            this.Controls.Add(this.utxtID);
            this.Controls.Add(this.ulblId);
            this.Name = "CadastroEmpresa";
            this.Text = "CadastroEmpresa";
            this.uPanelEndereco.ClientArea.ResumeLayout(false);
            this.uPanelEndereco.ClientArea.PerformLayout();
            this.uPanelEndereco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utxtComplemento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtBairro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtRua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtNumero)).EndInit();
            this.panelFuncionarios.ClientArea.ResumeLayout(false);
            this.panelFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtFund)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ulblId;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtID;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtRazao;
        private Infragistics.Win.Misc.UltraLabel ulblRazao;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtNome;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtCNPJ;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtTelefone;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor utxtEmail;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private Infragistics.Win.Misc.UltraPanel uPanelEndereco;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtComplemento;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtCidade;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtBairro;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtRua;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtNumero;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraLabel ultraLabel9;
        private Infragistics.Win.Misc.UltraLabel ultraLabel10;
        private Infragistics.Win.Misc.UltraLabel ultraLabel11;
        private Infragistics.Win.Misc.UltraButton btnGravar;
        private Infragistics.Win.Misc.UltraButton utxtSair;
        private Infragistics.Win.Misc.UltraPanel panelFuncionarios;
        private System.Windows.Forms.ListBox lbFuncCadastrado;
        private Infragistics.Win.Misc.UltraButton btnDeletar;
        private Infragistics.Win.Misc.UltraButton btnAdcFunc;
        private Infragistics.Win.Misc.UltraLabel lblValidacao;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor dtFund;
        private System.Windows.Forms.ListBox lbFunc;
        private System.Windows.Forms.ComboBox ucmbUf;
    }
}