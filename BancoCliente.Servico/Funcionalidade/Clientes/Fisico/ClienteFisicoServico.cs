using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Clientes;
using bancoCliente.Dominio.Funcionalidades.IClienteFisico;
using BancoCliente.Infra.BancoDados.Cliente.Fisico;

namespace BancoCliente.Servico.Funcionalidade.Clientes.Fisico
{
    public class ClienteFisicoServico : ClienteFisicoDAO
    {
        ClienteFisicoDAO _repositorioCliente = new ClienteFisicoDAO();

        public ClienteFisico Inserir (ClienteFisico entidade)
        {
            return _repositorioCliente.Adicionar(entidade);
        }

        public ClienteFisico Atualizar(ClienteFisico entidade)
        {
            return _repositorioCliente.Atualizar(entidade);
        }

        public long PegarPorId(int id)
        {
            return _repositorioCliente.ObterUltimoId();
        }

        public int Deletar(ClienteFisico entidade)
        {
            int id = Convert.ToInt32(entidade.Id.ToString());
            int retorno = _repositorioCliente.Excluir(id);
            _repositorioCliente.ExcluirEndereco(entidade.IdEndereco);
            return retorno;
        }

        public IList<ClienteFisico> PegarTodos()
        {
            return _repositorioCliente.ObterTodosItens();
        }
       
    }
}
