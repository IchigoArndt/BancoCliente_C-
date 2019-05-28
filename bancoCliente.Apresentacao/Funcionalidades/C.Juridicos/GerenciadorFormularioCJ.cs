using bancoCliente.Dominio.Funcionalidades.Clientes;
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
            IList<ClienteJuridico> cliente = _clienteServico.BuscarTodos();

            _clienteFisicoControl.PopularListagem(cliente);
        }

        public override UserControl CarregarListagem()
        {
            if (_clienteFisicoControl == null)
            {
                _clienteFisicoControl = new CJControl();
                _clienteFisicoControl.PopularListagem(_clienteServico.BuscarTodos());
            }
            return _clienteFisicoControl;
        }

        public override void Editar()
        {
            ClienteJuridico clienteSelecionado = _clienteFisicoControl.ObtemClienteSelecionado();
            if (clienteSelecionado != null)
            {
                CadastroClientesJuridicos dialog = new CadastroClientesJuridicos(clienteSelecionado);
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _clienteServico.Atualizar(clienteSelecionado);
                }

            }
            Atualizar();
        }

        public override void Excluir()
        {
            ClienteJuridico clienteSelecionado = _clienteFisicoControl.ObtemClienteSelecionado();
            if (clienteSelecionado != null)
            {
                _clienteServico.Deletar(clienteSelecionado);
                Atualizar();
            }
            else
            {
                MessageBox.Show("Não foi selecionado cliente nenhum para a exclusão");
            }
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro Cliente Júridico";
        }

    }
}
