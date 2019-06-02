using bancoCliente.Dominio.Enums;
using bancoCliente.Dominio.Funcionalidades.Funcionarios;
using BancoCliente.Servico.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancoCliente.Apresentacao.Funcionalidades.Funcionarios
{
    public partial class CadastroFuncionario : Form
    {

        Funcionario _Func;

        public CadastroFuncionario()
        {
            InitializeComponent();
            CarregaEstadosCombo();
        }

        public CadastroFuncionario(Funcionario funcionarioDominio) : this()
        {
            Func = funcionarioDominio;
        }


        public Funcionario Func
        {
            get { return _Func; }
            set
            {
                _Func = value;

                utxtNome.Text = _Func.getNome();
                utxtData.DateTime = _Func.getDataNasc();
                utxtEmail.Text = _Func.getEmail();
                utxtTel.Text = Convert.ToString(_Func.getTelefone());
                utxtCpf.Text = Convert.ToString(_Func.CPF);
                utxtSalario.Text = _Func.Salario.ToString();
                utxtCargo.Text = _Func.Cargo;
                //Endereço
                utxtBairro.Text = _Func.endereco.getBairro();
                utxtRua.Text = _Func.endereco.getLongradouro();
                utxtNumero.Text = Convert.ToString(_Func.endereco.getNumero());
                utxtCidade.Text = Convert.ToString(_Func.endereco.getCidade());
                utxtComplemento.Text = Convert.ToString(_Func.endereco.getComplemento());
                ucmbUf.SelectedItem = _Func.endereco.getUf();
            }
        }


        private void utxtTel_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarNumeros(utxtTel.Text))
            {

                lblValidacao.Text = "O campo não contém somente números";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;

        }

        private void utxtNome_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtNome.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }

        private void utxtTel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void utxtNumero_ValueChanged(object sender, EventArgs e)
        {

        }

        private void utxtNumero_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarNumeros(utxtNumero.Text))
            {
                lblValidacao.Text = "O campo não contém somente números";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Func == null)
                    _Func = new Funcionario();
                //final do if
                _Func.setNome(utxtNome.Text);
                _Func.setDataNasc(utxtData.DateTime);
                _Func.setEmail(utxtEmail.Text);
                _Func.setTelefone(utxtTel.Text);
                _Func.CPF = utxtCpf.Text;
                _Func.Cargo = utxtCargo.Text;
                _Func.Salario = Convert.ToInt32(utxtSalario.Text);
                //Endereço
                _Func.endereco.setBairro(utxtBairro.Text);
                _Func.endereco.setLongradouro(utxtRua.Text);
                _Func.endereco.setNumero(Convert.ToInt32(utxtNumero.Text));
                _Func.endereco.setCidade(utxtCidade.Text);
                _Func.endereco.setComplemento(utxtComplemento.Text);
                _Func.endereco.setUf((EnumUfs)ucmbUf.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void CarregaEstadosCombo()
        {
            foreach (var item in Enum.GetValues(typeof(EnumUfs)))
            {
                ucmbUf.Items.Add(item);
            }
        }


        private void utxtEmail_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarEmail(utxtEmail.Text))
            {
                lblValidacao.Text = "O Email informado não está valido";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }

        private void utxtRua_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtRua.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }

        private void utxtComplemento_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtComplemento.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }

        private void utxtBairro_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtBairro.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }

        private void utxtCidade_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtCidade.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }

        private void utxtCpf_leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtCpf.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }

        private void dateTimeEditor_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarData(utxtData.DateTime))
            {
                lblValidacao.Text = "A data informada não está valido";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }

        private void ubtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

