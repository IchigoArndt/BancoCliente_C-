using bancoCliente.Dominio.Funcionalidades.Empresas;
using BancoCliente.Servico.Funcionalidade.Empresas;
using BancoCliente.Servico.Funcionalidade.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancoCliente.Apresentacao.Funcionalidades.Empresas
{
    class GeenciadorFormularioEmpresa : GerenciadorFormulario
    {
        EmpresaServico _empresaServico = new EmpresaServico();
        FuncionarioServico _funcionarioServico = new FuncionarioServico();
        empresaControl _empresaControl = new empresaControl(); 
        public override void Adicionar()
        {
            CadastroEmpresa Empresa = new CadastroEmpresa();
            Empresa.CarregaListaFuncionarioNãoCadastrado(_funcionarioServico.PegarTodos().ToList());
            DialogResult result = Empresa.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    _empresaServico.Inserir(Empresa.empresa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public override void Atualizar()
        {
            IList<Empresa> cliente = _empresaServico.PegarTodos().ToList();

            _empresaControl.PopularListagem(cliente);
        }

        public override UserControl CarregarListagem()
        {
            if(_empresaControl == null)
            {
                _empresaControl = new empresaControl();
            }
                return _empresaControl;
        }

        public override void Editar()
        {
            Empresa clienteSelecionado = _empresaControl.ObtemDisciplinaSelecionada();
            if (clienteSelecionado != null)
            {
                CadastroEmpresa dialog = new CadastroEmpresa(clienteSelecionado);
                dialog.CarregaListaFuncionarioNãoCadastrado(_funcionarioServico.PegarTodos().ToList());
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _empresaServico.Atualizar(clienteSelecionado);
                }

            }
            Atualizar();
        }

        public override void Excluir()
        {
            Empresa clienteSelecionado = _empresaControl.ObtemDisciplinaSelecionada();
            if (clienteSelecionado != null)
            {
                _empresaServico.Deletar(clienteSelecionado);
                Atualizar();
            }
            else
            {
                MessageBox.Show("Não foi selecionado cliente nenhum para a exclusão");
            }
        }

        public override string ObtemTipoCadastro()
        {
            return "Cadastro de Empresa";
        }
    }
}
