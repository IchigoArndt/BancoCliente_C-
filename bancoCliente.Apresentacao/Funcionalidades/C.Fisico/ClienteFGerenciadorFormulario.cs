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
        ClienteFisicoValidacao clienteFisicoValidacao;

        public override void Adicionar() 
        {
            CadastroClienteFisico dialog = new CadastroClienteFisico();

            dialog.carregaContaCombo(_contaServico.PegarTodos());

            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                    clienteFisicoValidacao = new ClienteFisicoValidacao(dialog.Cliente);

                    var validador = clienteFisicoValidacao.Validate();

                    if (validador.IsValid)
                    {
                        try
                       {
                        _clienteServico.Inserir(dialog.Cliente);
                       }
                    catch (Exception ex)
                       {
                        MessageBox.Show(ex.Message);
                       }
                }
                else
                {
                    foreach (var item in validador.Errors)
                    {
                        MessageBox.Show(item.ErrorMessage);
                    }
                }
               
            }
            Atualizar();
        }

        public override void Atualizar()
        {

           IList<ClienteFisico> cliente = _clienteServico.PegarTodos();

            _clienteFisicoControl.PopularListagem(cliente.ToList());
        }

        public override UserControl CarregarListagem()
        {
            if(_clienteFisicoControl == null)
            {
                _clienteFisicoControl = new CFisicoControl();
                _clienteFisicoControl.PopularListagem(_clienteServico.PegarTodos().ToList());
            }
            return _clienteFisicoControl;
        }

        public override void Editar()
        {
            ClienteFisico clienteSelecionado = _clienteFisicoControl.ObtemItemSelecionado();
            if(clienteSelecionado != null)
            {
                CadastroClienteFisico dialog = new CadastroClienteFisico(clienteSelecionado);
                dialog.carregaContaCombo(_contaServico.PegarTodos().ToList());
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    clienteFisicoValidacao = new ClienteFisicoValidacao(clienteSelecionado);
                    var validador = clienteFisicoValidacao.Validate();

                    if (validador.IsValid)
                    {
                        try
                        {
                            _clienteServico.Atualizar(clienteSelecionado);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Alguns campos não estão válidos");
                    }
                    
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
