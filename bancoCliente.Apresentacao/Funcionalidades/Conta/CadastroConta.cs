using bancoCliente.Dominio.Funcionalidades.Conta;
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

namespace bancoCliente.Apresentacao.Funcionalidades.Contas
{
    public partial class CadastroConta : Form
    {

        ContaDominio _conta;

        public CadastroConta()
        {
            InitializeComponent();
            ckbTipoPoupanca.Checked = true;
        }

        public CadastroConta(ContaDominio contaVelha) : this()
        {
            conta = contaVelha;
        }

        private void utxtId_Leave(object sender, EventArgs e)
        {

        }

        private void utxtAgencia_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarString(utxtAgencia.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }

        private void utxtTaxa_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarNumeros(utxtAgencia.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }

        private void utxtTipo_Leave(object sender, EventArgs e)
        {
            if (!ValidacaoCampos.ValidarNumeros(utxtAgencia.Text))
            {
                lblValidacao.Text = "O campo não está valido";
                ubtnGravar.Enabled = false;
            }
            else
                ubtnGravar.Enabled = true;
        }
        public ContaDominio conta
        {
            get { return _conta; }
            set
            {
                _conta = value;

                utxtAgencia.Text = _conta.Agencia;
                utxtId.Text = _conta.Id.ToString();
                utxtTaxa.Text = _conta.taxaManutencao.ToString();
                RetornaContaSelecionada(_conta.TipoConta);
            }
        }
        private void ubtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_conta == null)
                    _conta = new ContaDominio();

                _conta.Agencia = utxtAgencia.Text;
                _conta.taxaManutencao = Convert.ToInt32(utxtTaxa.Text);
                _conta.TipoConta = RetornaTipoConta();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }

        private int RetornaTipoConta()
        {
            int tipo = 0;

            if (ckbTipoPoupanca.Checked)
                return tipo = 0;
            if (ckbTipoCorrente.Checked)
                return tipo = 1;
            if (ckbTipoSalario.Checked)
                return tipo = 2;
            if (ckbTipoDigital.Checked)
                return tipo = 3;

            return tipo;
        }
        private void RetornaContaSelecionada(int tipo)
        {
            switch (tipo)
            {
                case 0:
                    {
                        ckbTipoPoupanca.Checked = true;
                        break;
                    }
                case 1:
                    {
                        ckbTipoCorrente.Checked = true;
                        ckbTipoPoupanca.Checked = false;
                        break;
                    }
                case 2:
                    {
                        ckbTipoSalario.Checked = true;
                        ckbTipoPoupanca.Checked = false;
                        break;
                    }
                case 3:
                    {
                        ckbTipoDigital.Checked = true;
                        ckbTipoPoupanca.Checked = false;
                        break;
                    }

                default:
                    break;
            }
        }
    }
}
