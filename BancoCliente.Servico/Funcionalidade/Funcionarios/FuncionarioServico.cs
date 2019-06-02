using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Funcionarios;
using BancoCliente.Infra.BancoDados.Funcionarios;

namespace BancoCliente.Servico.Funcionalidade.Funcionarios
{
    public class FuncionarioServico : IFuncionarioServico
    {
        FuncionarioDAO _funcionario = new FuncionarioDAO();

        public Funcionario Adicionar(Funcionario entidade)
        {
            return _funcionario.Adicionar(entidade);
        }

        public Funcionario Atualizar(Funcionario entidade)
        {
            return _funcionario.Atualizar(entidade);
        }

        public Funcionario BuscarPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Funcionario> BuscarTodos()
        {
            return _funcionario.BuscarTodos();
        }

        public void Deletar(Funcionario entidade)
        {
            _funcionario.Deletar(entidade);
        }
    }
}
