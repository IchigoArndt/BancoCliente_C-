
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

namespace bancoCliente.Apresentacao.Funcionalidades.C.Fisico
{
    public partial class CadastroClienteFisico : Form
    {
        
        public CadastroClienteFisico()
        {
            InitializeComponent();
            btnGravar.Enabled = false;
        }

        ClienteFisico _clienteServico;

        public ClienteFisico Cliente
        {
            get { return _clienteServico; }
            set
            {
                utxtNome.Text = _clienteServico.getNome();
                dateTimeEditor.DateTime = _clienteServico.getDataNasc();
                utxtEmail.Text = _clienteServico.getEmail();
                utxtLimite.Text = Convert.ToString(_clienteServico.getLimite());
                utxtTel.Text = Convert.ToString(_clienteServico.getTelefone());
                utxtCpf.Text = Convert.ToString(_clienteServico.getCpf());
                utxtLimiteSaque.Text = Convert.ToString(_clienteServico.getLimitePagamento());
                utxtQtdLimite.Text = Convert.ToString(_clienteServico.getQuantidadeLimite());
                //Endereço
                utxtRua.Text = _clienteServico.endereco.getLongradouro();
                utxtNumero.Text = Convert.ToString(_clienteServico.endereco.getNumero());
                utxtCidade.Text = Convert.ToString(_clienteServico.endereco.getCidade());
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
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_clienteServico == null)
                    _clienteServico = new ClienteFisico();
                //final do if
                _clienteServico.setNome( utxtNome.Text);
                _clienteServico.setDataNasc(dateTimeEditor.DateTime);
                _clienteServico.setEmail(utxtEmail.Text);
                _clienteServico.setLimite(Convert.ToInt32(utxtLimite.Text));
                _clienteServico.setTelefone(utxtTel.Text);
                _clienteServico.setCpf(utxtCpf.Text);
                _clienteServico.setLimitePagamento(Convert.ToInt32(utxtLimiteSaque));
                _clienteServico.setQuantidadeLimite(Convert.ToInt32(utxtQtdLimite.Text));
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

        private void utxtCpf_leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtCpf.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtQtdLimite_leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarNumeros(utxtQtdLimite.Text))
            {
                lblValidacao.Text = "O campo não contém somente números";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void utxtLimiteSaque_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarNumeros(utxtLimiteSaque.Text))
            {
                lblValidacao.Text = "O campo não contém somente números";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }

        private void dateTimeEditor_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarData(dateTimeEditor.DateTime))
            {
                lblValidacao.Text = "A data informada não está valido";
                btnGravar.Enabled = false;
            }
            else
                btnGravar.Enabled = true;
        }
    }
}
