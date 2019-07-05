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
    public class FuncionarioServico : FuncionarioDAO
    {
        FuncionarioDAO _repositorioCliente = new FuncionarioDAO();

        public Funcionario Inserir(Funcionario entidade)
        {
            return _repositorioCliente.Adicionar(entidade);
        }

        public Funcionario Atualizar(Funcionario entidade)
        {
            return _repositorioCliente.Atualizar(entidade);
        }

        public long PegarPorId(int id)
        {
            return _repositorioCliente.ObterUltimoId();
        }

        public int Deletar(Funcionario entidade)
        {
            int id = Convert.ToInt32(entidade.Id.ToString());
            int retorno = _repositorioCliente.Excluir(id);
            _repositorioCliente.ExcluirEndereco(entidade.IdEndereco);
            return retorno;
        }

        public IList<Funcionario> PegarTodos()
        {
            return _repositorioCliente.ObterTodosItens();
        }
    }
}
