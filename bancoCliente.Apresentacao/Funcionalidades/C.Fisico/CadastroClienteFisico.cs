using bancoCliente.Apresentacao.Funcionalidades.validacao;
using bancoCliente.Dominio.Funcionalidades.Clientes;
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
        Validacao vl = new Validacao();
        public CadastroClienteFisico()
        {
            InitializeComponent();
        }

        ClienteFisico _clienteServico;

        public ClienteFisico Cliente
        {
            get { return _clienteServico; }
            set
            {
                utxtNome.Text = _clienteServico.getNome();
                utxtDnasc.Text = Convert.ToString(_clienteServico.getDataNasc());
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
            
            if (!vl.ValidaNumero(utxtTel.Text))
            {
                MessageBox.Show("O campo está vazio ou não contém somente número");
            }
        }

        private void utxtNome_ValueChanged(object sender, EventArgs e)
        {
            if (vl.validaLimitCaracter(utxtNome.Text))
            {
                MessageBox.Show("Você so pode digitar até 50 caracters");
                //utxtNome.
            }
        }

        private void utxtNumero_ValueChanged(object sender, EventArgs e)
        {

        }

        private void utxtNumero_Leave(object sender, EventArgs e)
        {
            if (vl.validaNumeroVirgula(utxtNumero.Text))
            {
                MessageBox.Show("Você so pode digitar uma virgula");
                //utxtNome.
            }
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_clienteServico == null)
                    _clienteServico = new ClienteFisico();
                //final do if
                _clienteServico.setNome( utxtNome.Text);
                _clienteServico.setDataNasc(Convert.ToDateTime(utxtDnasc.Text));
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
    }
}
