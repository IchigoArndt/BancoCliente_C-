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
        FuncionarioServico Func = new FuncionarioServico();
        funcionarioControl FunControl;
        public override void Adicionar()
        {
            DialogResult result = Conta.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    Func.Adicionar(Conta.Func);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public override void Atualizar()
        {
            //
        }

        public override UserControl CarregarListagem()
        {
            if (FunControl == null)
            {
                FunControl = new funcionarioControl();
            }
            return FunControl;
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
            return "Cadastro de Funcionários";
        }
    }
}
