using bancoCliente.Dominio.Enums;
using bancoCliente.Dominio.Funcionalidades.Empresas;
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
        List<Funcionario> _todosFuncionarios = new List<Funcionario>();

        public CadastroEmpresa()
        {
            InitializeComponent();
            PreencheComboEstados();
        }

        public CadastroEmpresa(Empresa empresaDominio) : this()
        {
            empresa = empresaDominio;
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
                _empresa.Endereco.setUf((EnumUfs)ucmbUf.SelectedItem);
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
        private void preencheListaFuncionario()
        {
            lbFunc.Items.Clear();

            foreach (var item in _empresa.funcionarios)
            {
               lbFuncCadastrado.Items.Add(item);
            }
        }

        public void CarregaListaFuncionarioNãoCadastrado(List<Funcionario>funcionarios)
        {

            _todosFuncionarios = funcionarios.OrderBy(C => C.Id).ToList();

            foreach (var item in funcionarios)
            {
                lbFunc.Items.Add(item);
            }
        }

        public Empresa empresa
        {
            get { return _empresa; }
            set
            {
                _empresa = value;
                utxtNome.Text = _empresa.NomeFantasia;
                utxtRazao.Text = _empresa.RazaoSocial;
                utxtEmail.Text = _empresa.Email;
                dtFund.DateTime = _empresa.DataFund;
                utxtTelefone.Text = Convert.ToString(_empresa.Telefone);
                utxtCNPJ.Text = Convert.ToString(_empresa.Cnpj);
                utxtID.Text = _empresa.Id.ToString();
                preencheListaFuncionario();
                //Endereço
                utxtBairro.Text = empresa.Endereco.getBairro();
                utxtRua.Text = _empresa.Endereco.getLongradouro();
                utxtNumero.Text = Convert.ToString(_empresa.Endereco.getNumero());
                utxtCidade.Text = Convert.ToString(_empresa.Endereco.getCidade());
                utxtComplemento.Text = Convert.ToString(_empresa.Endereco.getComplemento());
                ucmbUf.SelectedItem = _empresa.Endereco.getUf();
            }
        }
        private void PreencheComboEstados()
        {
            foreach (var item in Enum.GetValues(typeof(EnumUfs)))
            {
                ucmbUf.Items.Add(item);
            }
        }

        private void btnAdcFunc_Click(object sender, EventArgs e)
        {
            Funcionario func = (Funcionario)lbFunc.SelectedItem;
            var funcCadastrado = false;
            foreach (var item in lbFuncCadastrado.Items)
            {
                var funcComparado = (Funcionario)item;
                if (funcComparado.Id == func.Id)
                {
                    MessageBox.Show("Funcionário Já Cadastrado !");
                    funcCadastrado = true;
                }
                
            }
            if (!funcCadastrado)
            {
                lbFuncCadastrado.Items.Add(func);
            }
           
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Funcionario func = (Funcionario)lbFuncCadastrado.SelectedItem;
            //List<Funcionario> funcs = new List<Funcionario>();
            if (func != null)
            {
                lbFuncCadastrado.Items.Remove(func);
            }
            else
            {
                MessageBox.Show("Selecione um item antes de excluir");
            }
            lbFunc.Items.Clear();
            foreach (var item in _todosFuncionarios)
            {
                lbFunc.Items.Add(item);
            }
        }

        private void ucmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
