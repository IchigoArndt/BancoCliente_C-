using bancoCliente.Dominio.Funcionalidades.Clientes;
using BancoCliente.Servico.Funcionalidade.Clientes.Fisico;
using BancoCliente.Servico.Funcionalidade.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancoCliente.Apresentacao.Funcionalidades.C.Fisico
{
    public class ClienteFGerenciadorFormulario : GerenciadorFormulario
    {
        CFisicoControl _clienteFisicoControl;
        ClienteFisicoServico _clienteServico = new ClienteFisicoServico();
        ContaServico _contaServico = new ContaServico();

        public override void Adicionar() 
        {
            CadastroClienteFisico dialog = new CadastroClienteFisico();

            dialog.carregaContaCombo(_contaServico.retornaTipoConta().ToList());

            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                try
                {
                    _clienteServico.Adicionar(dialog.Cliente);
                    
                    //MessageBox.Show("Abriu a Tela !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Atualizar();
        }

        public override void Atualizar()
        {
            IList<ClienteFisico> cliente = _clienteServico.BuscarTodos();

            _clienteFisicoControl.PopularListagem(cliente);
        }

        public override UserControl CarregarListagem()
        {
            if(_clienteFisicoControl == null)
            {
                _clienteFisicoControl = new CFisicoControl();
                _clienteFisicoControl.PopularListagem(_clienteServico.BuscarTodos());
            }
            return _clienteFisicoControl;
        }

        public override void Editar()
        {
            ClienteFisico clienteSelecionado = _clienteFisicoControl.ObtemItemSelecionado();
            if(clienteSelecionado != null)
            {
                CadastroClienteFisico dialog = new CadastroClienteFisico(clienteSelecionado);
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
            ClienteFisico clienteSelecionado = _clienteFisicoControl.ObtemItemSelecionado();
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
            return "Cadastro Cliente Físico";
        }
    }
}
