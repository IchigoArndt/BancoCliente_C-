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
    public class ContaServico : ContaDAO
    {

        ContaDAO _repositorioCliente = new ContaDAO();

        public ContaDominio Inserir(ContaDominio entidade)
        {
            return _repositorioCliente.Adicionar(entidade);
        }

        public ContaDominio Atualizar(ContaDominio entidade)
        {
            return _repositorioCliente.Atualizar(entidade);
        }

        public long PegarPorId(int id)
        {
            return _repositorioCliente.ObterUltimoId();
        }

        public int Deletar(ContaDominio entidade)
        {
            return _repositorioCliente.Excluir(entidade.Id);
        }

        public IList<ContaDominio> PegarTodos()
        {
            return _repositorioCliente.ObterTodosItens();
        }

    }
}
