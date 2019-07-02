using bancoCliente.Dominio.Funcionalidades.Funcionarios;
using BancoCliente.Servico.Funcionalidade.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancoCliente.Apresentacao.Funcionalidades.Funcionarios
{
    public class GerenciadorFormularioFuncionario : GerenciadorFormulario
    {
        CadastroFuncionario Conta = new CadastroFuncionario();
        FuncionarioServico _funcServico = new FuncionarioServico();
        funcionarioControl _funControl;

        public override void Adicionar()
        {
            DialogResult result = Conta.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    _funcServico.Inserir(Conta.Func);
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
            IList<Funcionario> cliente = _funcServico.PegarTodos().ToList();

            _funControl.PopularListagem(cliente);
        }

        public override UserControl CarregarListagem()
        {
            if (_funControl == null)
            {
                _funControl = new funcionarioControl();
            }
            return _funControl;
        }

        public override void Editar()
        {
            Funcionario funcionarioSelecionado = _funControl.ObtemDisciplinaSelecionada();
            if (funcionarioSelecionado != null)
            {
                CadastroFuncionario dialog = new CadastroFuncionario(funcionarioSelecionado);
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _funcServico.Atualizar(funcionarioSelecionado);
                }
            }
            Atualizar();
        }

        public override void Excluir()
        {
            Funcionario funcionarioSelecionado = _funControl.ObtemDisciplinaSelecionada();
            if (funcionarioSelecionado != null)
            {
                _funcServico.Deletar(funcionarioSelecionado);
                Atualizar();
            }
            else
            {
                MessageBox.Show("Não foi selecionado cliente nenhum para a exclusão");
            }
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Funcionários";
        }
    }
}
