using bancoCliente.Dominio.Funcionalidades.Empresa;
using bancoCliente.Dominio.Funcionalidades.Funcionarios;
using BancoCliente.Servico.Base;
using BancoCliente.Servico.Funcionalidade.Empresas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancoCliente.Apresentacao.Funcionalidades.Empresas
{
    public partial class CadastroEmpresa : Form
    {
        Empresa _empresa;

        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void ultraFormattedTextEditor1_LinkClicked(object sender, Infragistics.Win.FormattedLinkLabel.LinkClickedEventArgs e)
        {

        }

        private void ultraLabel1_Click(object sender, EventArgs e)
        {

        }

        private void utxtTel_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarNumeros(utxtTelefone.Text))
            {

                lblValidacao.Text = "O campo não contém somente números";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;

        }
        private void utxtNome_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtNome.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtNumero_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarNumeros(utxtNumero.Text))
            {
                lblValidacao.Text = "O campo não contém somente números";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarEmail(utxtEmail.Text))
            {
                lblValidacao.Text = "O Email informado não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtRua_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtRua.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtComplemento_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtComplemento.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtBairro_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtBairro.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtCidade_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtCidade.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtCnpj_leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtCNPJ.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void dtFund_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarData(dtFund.DateTime))
            {
                lblValidacao.Text = "O campo não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_empresa == null)
                    _empresa = new Empresa();
                //final do if
                _empresa.NomeFantasia = utxtNome.Text;
                _empresa.RazaoSocial = utxtRazao.Text;
                _empresa.Email = utxtEmail.Text;
                _empresa.Telefone = utxtTelefone.Text;
                _empresa.Cnpj = utxtCNPJ.Text;
                _empresa.funcionarios = preencheListaFuncionario(true);
                //Endereço
                _empresa.Endereco.setLongradouro(utxtRua.Text);
                _empresa.Endereco.setNumero(Convert.ToInt32(utxtNumero.Text));
                _empresa.Endereco.setCidade(utxtCidade.Text);
                _empresa.Endereco.setComplemento(utxtComplemento.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private List<Funcionario> preencheListaFuncionario(bool empresaNova)
        {
            List<Funcionario> funcs = new List<Funcionario>();
            Funcionario func = new Funcionario();
                foreach (var item in lbFunc.Items)
                {
                    func = (Funcionario)item;
                    funcs.Add(func);
                }
            return funcs;
        }
        private void preencheListaFuncionarioCadastrado()
        {
                foreach (var item in _empresa.funcionarios)
                {
                    lbFuncCadastrado.Items.Add(item);
                }
        }

        public Empresa empresa
        {
            get { return _empresa; }
            set
            {
                utxtNome.Text = _empresa.NomeFantasia;
                utxtRazao.Text = _empresa.RazaoSocial;
                utxtEmail.Text = _empresa.Email;
                utxtTelefone.Text = Convert.ToString(_empresa.Telefone);
                utxtCNPJ.Text = Convert.ToString(_empresa.Cnpj);
                preencheListaFuncionarioCadastrado();
                //Endereço
                utxtRua.Text = _empresa.Endereco.getLongradouro();
                utxtNumero.Text = Convert.ToString(_empresa.Endereco.getNumero());
                utxtCidade.Text = Convert.ToString(_empresa.Endereco.getCidade());
                utxtComplemento.Text = Convert.ToString(_empresa.Endereco.getComplemento());
            }
        }

    }
}
