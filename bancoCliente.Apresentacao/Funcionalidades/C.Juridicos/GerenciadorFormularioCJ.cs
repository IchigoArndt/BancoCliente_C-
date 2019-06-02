using bancoCliente.Dominio.Funcionalidades.Clientes;
using BancoCliente.Servico.Funcionalidade.Clientes.Jurudico;
using BancoCliente.Servico.Funcionalidade.Contas;
using BancoCliente.Servico.Funcionalidade.Empresas;
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
        ContaServico _contaServico = new ContaServico();
        EmpresaServico _empresaServico = new EmpresaServico();

        public override void Adicionar()
        {
            CadastroClientesJuridicos dialog = new CadastroClientesJuridicos();
            dialog.carregaContaCombo(_contaServico.BuscarTodos().ToList());
            dialog.PreencheComboEmpresas(_empresaServico.BuscarTodos().ToList());
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                try
                {
                    /* Fica  Para quando for implementado o acesso ao banco 
                    */
                    _clienteServico.Adicionar(dialog.Cliente);
                    //ListarLivros();
                   // MessageBox.Show("Abriu a Tela !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Atualizar();
            }
        }

        public override void Atualizar()
        {
            IList<ClienteJuridico> cliente = _clienteServico.BuscarTodos().OrderBy(C => C.id).ToList();

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
                dialog.carregaContaCombo(_contaServico.BuscarTodos().ToList());
                dialog.PreencheComboEmpresas(_empresaServico.BuscarTodos().ToList());
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
