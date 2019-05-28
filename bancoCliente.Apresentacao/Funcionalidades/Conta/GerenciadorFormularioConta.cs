using bancoCliente.Dominio.Funcionalidades.Conta;
using BancoCliente.Servico.Funcionalidade.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancoCliente.Apresentacao.Funcionalidades.Contas
{
    public class GerenciadorFormularioConta : GerenciadorFormulario
    {
        ContaServico _contaServico = new ContaServico();
        ContaControl _contaControl = new ContaControl();

        public override void Adicionar()
        {
            CadastroConta Conta = new CadastroConta();
            DialogResult result = Conta.ShowDialog();
            if(result == DialogResult.OK)
            {
                try
                {
                    _contaServico.Adicionar(Conta.conta);
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
            IList<ContaDominio> cliente = _contaServico.BuscarTodos();

            _contaControl.PopularListagem(cliente);
        }

        public override UserControl CarregarListagem()
        {
            if (_contaControl == null)
            {
                _contaControl = new ContaControl();

                _contaControl.PopularListagem(_contaServico.BuscarTodos());
            }
            return _contaControl;
        }

        public override void Editar()
        {
            ContaDominio clienteSelecionado = _contaControl.ObtemContaSelecionada();
            if (clienteSelecionado != null)
            {
                CadastroConta dialog = new CadastroConta(clienteSelecionado);
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _contaServico.Atualizar(clienteSelecionado);
                }
            }
            Atualizar();
        }

        public override void Excluir()
        {
            ContaDominio clienteSelecionado = _contaControl.ObtemContaSelecionada();
            if (clienteSelecionado != null)
            {
                _contaServico.Deletar(clienteSelecionado);
                Atualizar();
            }
            else
            {
                MessageBox.Show("Não foi selecionado cliente nenhum para a exclusão");
            }
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro Conta";
        }
    }
}
