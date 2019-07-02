using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Funcionarios;
using bancoCliente.Dominio.Funcionalidades.IFuncionarios;
using BancoCliente.Infra.BancoDados.Funcionarios;

namespace BancoCliente.Servico.Funcionalidade.Funcionarios
{
    public class FuncionarioServico : IFuncionarioServico
    {
        FuncionarioDAO _funcionario = new FuncionarioDAO();

        private readonly IFuncionario _repositorioEmpresa;

        public Funcionario Inserir(Funcionario entidade)
        {
            return _repositorioEmpresa.Inserir(entidade);
        }

        public bool Atualizar(Funcionario entidade)
        {
            return _repositorioEmpresa.Atualizar(entidade);
        }

        public Funcionario PegarPorId(int id)
        {
            return _repositorioEmpresa.PegarPorId(id);
        }

        public IQueryable<Funcionario> PegarTodos()
        {
            return _repositorioEmpresa.PegarTodos();
        }

        public bool Deletar(Funcionario entidade)
        {
            return _repositorioEmpresa.Deletar(entidade);
        }
    }
}
