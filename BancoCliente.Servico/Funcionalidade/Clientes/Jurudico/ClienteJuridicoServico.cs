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
    public class ClienteJuridicoServico : IClienteJuridicoServico
    {

        ClienteJuridicoDAO _clienteDAO = new ClienteJuridicoDAO();

        private readonly IClienteJuridico _repositorioCliente;

        public ClienteJuridico Inserir (ClienteJuridico entidade)
        {
            return _repositorioCliente.Inserir(entidade);
        }

        public bool Atualizar(ClienteJuridico entidade)
        {
            return _repositorioCliente.Atualizar(entidade);
        }

        public ClienteJuridico PegarPorId(int id)
        {
            return _repositorioCliente.PegarPorId(id);
        }

        public IQueryable<ClienteJuridico> PegarTodos()
        {
            return _repositorioCliente.PegarTodos();
        }

        public bool Deletar(ClienteJuridico entidade)
        {
           return _repositorioCliente.Deletar(entidade);
        }
    }
}
