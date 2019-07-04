using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Clientes;
using bancoCliente.Dominio.Funcionalidades.IClienteJuridico;
using BancoCliente.Infra.BancoDados.Cliente.Jurudico;

namespace BancoCliente.Servico.Funcionalidade.Clientes.Jurudico
{
    public class ClienteJuridicoServico : ClienteJuridicoDAO
    {
        ClienteJuridicoDAO _repositorioCliente = new ClienteJuridicoDAO();

        public ClienteJuridico Inserir(ClienteJuridico entidade)
        {
            return _repositorioCliente.Adicionar(entidade);
        }

        public ClienteJuridico Atualizar(ClienteJuridico entidade)
        {
            return _repositorioCliente.Atualizar(entidade);
        }

        public long PegarPorId(int id)
        {
            return _repositorioCliente.ObterUltimoId();
        }

        public int Deletar(ClienteJuridico entidade)
        {
            var id = Convert.ToInt32(entidade.Id.ToString());
            return _repositorioCliente.Excluir(id);
        }

        public IList<ClienteJuridico> PegarTodos()
        {
            return _repositorioCliente.ObterTodosItens();
        }

    }
}
