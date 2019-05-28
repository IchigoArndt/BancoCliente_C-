using bancoCliente.Dominio.Funcionalidades.Clientes;
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

namespace bancoCliente.Apresentacao.Funcionalidades.ClientesJuridicos
{
    public partial class CadastroClientesJuridicos : Form
    {
        public CadastroClientesJuridicos()
        {
            InitializeComponent();
        }
        ClienteJuridico _clienteServico;

        public CadastroClientesJuridicos(ClienteJuridico cliente) : this()
        {
            Cliente = cliente;
        }

        public ClienteJuridico Cliente
        {
            get { return _clienteServico; }
            set
            {

                _clienteServico = value;

                utxtNome.Text = _clienteServico.getNome();
                utxtEmail.Text = _clienteServico.getEmail();
                utxtLimite.Text = Convert.ToString(_clienteServico.getLimite());
                utxtTel.Text = Convert.ToString(_clienteServico.getTelefone());
                utxtCnpj.Text = Convert.ToString(_clienteServico.getCnpj());
                //Endereço
                utxtRua.Text = _clienteServico.endereco.getLongradouro();
                utxtNumero.Text = Convert.ToString(_clienteServico.endereco.getNumero());
                utxtCidade.Text = Convert.ToString(_clienteServico.endereco.getCidade());
                utxtBairro.Text = _clienteServico.endereco.getBairro();
                utxtComplemento.Text = Convert.ToString(_clienteServico.endereco.getComplemento());
            }
        }

        private void utxtTel_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarNumeros(utxtTel.Text))
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

        private void utxtConta_leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtConta.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtLimite_ValueChanged(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarNumeros(utxtLimite.Text))
            {
                lblValidacao.Text = "O campo não contém somente números";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtCnpj_leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtCnpj.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtEmail_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_clienteServico == null)
                    _clienteServico = new ClienteJuridico();
                //final do if
                _clienteServico.setNome(utxtNome.Text);
                _clienteServico.setEmail(utxtEmail.Text);
                _clienteServico.setLimite(Convert.ToInt32(utxtLimite.Text));
                _clienteServico.setTelefone(utxtTel.Text);
                _clienteServico.setCnpj(utxtCnpj.Text);
                //Endereço
                _clienteServico.endereco.setLongradouro(utxtRua.Text);
                _clienteServico.endereco.setNumero(Convert.ToInt32(utxtNumero.Text));
                _clienteServico.endereco.setCidade(utxtCidade.Text);
                _clienteServico.endereco.setComplemento(utxtComplemento.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
