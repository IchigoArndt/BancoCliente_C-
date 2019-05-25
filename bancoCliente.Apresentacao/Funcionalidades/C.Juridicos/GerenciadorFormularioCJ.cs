using BancoCliente.Servico.Funcionalidade.Clientes.Jurudico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancoCliente.Apresentacao.Funcionalidades.ClientesJuridicos
{
    public class GerenciadorFormularioCJ : GerenciadorFormulario
    {
        CJControl _clienteFisicoControl;
        ClienteJuridicoServico _clienteServico = new ClienteJuridicoServico();

        public override void Adicionar()
        {
            CadastroClientesJuridicos dialog = new CadastroClientesJuridicos();
           
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                try
                {
                    /* Fica  Para quando for implementado o acesso ao banco 
                    */
                    _clienteServico.Adicionar(dialog.Cliente);
                    //ListarLivros();
                    MessageBox.Show("Abriu a Tela !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public override void Atualizar()
        {
            //throw new NotImplementedException();
        }

        public override UserControl CarregarListagem()
        {
            if (_clienteFisicoControl == null)
            {
                _clienteFisicoControl = new CJControl();
            }
            return _clienteFisicoControl;
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro Cliente Júridico";
        }

    }
}
