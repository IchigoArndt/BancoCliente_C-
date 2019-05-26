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
                utxtAgencia.Text = _conta.agencia;
                utxtId.Text = _conta.id.ToString();
                utxtTaxa.Text = _conta.taxaManutencao.ToString();
            }
        }
        private void ubtnGravar_Click(object sender, EventArgs e)
        {
            _conta.agencia = utxtAgencia.Text;
            _conta.taxaManutencao = Convert.ToInt32(utxtTaxa.Text);
        }
    }
}
