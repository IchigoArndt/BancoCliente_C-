using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Conta;
using bancoCliente.Dominio.Funcionalidades.IContas;
using BancoCliente.Infra.BancoDados.Conta;

namespace BancoCliente.Servico.Funcionalidade.Contas
{
    public class ContaServico : IContaServico
    {

        ContaDAO _conta = new ContaDAO();

        private readonly IConta _repositorioConta;

        public ContaDominio Inserir(ContaDominio entidade)
        {
           return _repositorioConta.Inserir(entidade);
        }

        public bool Atualizar(ContaDominio entidade)
        {
            return _repositorioConta.Atualizar(entidade);
        }

        public ContaDominio PegarPorId(int id)
        {
            return _repositorioConta.PegarPorId(id);
        }

        public IQueryable<ContaDominio> PegarTodos()
        {
            return _repositorioConta.PegarTodos();
        }

        public bool Deletar(ContaDominio entidade)
        {
            return _repositorioConta.Deletar(entidade);
        }
    }
}
