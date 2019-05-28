using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Clientes;
using BancoCliente.Infra.BancoDados.Cliente.Jurudico;

namespace BancoCliente.Servico.Funcionalidade.Clientes.Jurudico
{
    public class ClienteJuridicoServico : IClienteJuridicoServico
    {

        ClienteJuridicoDAO _clienteDAO = new ClienteJuridicoDAO();

        public ClienteJuridico Adicionar(ClienteJuridico entidade)
        {
            return _clienteDAO.Adicionar(entidade);
        }

        public ClienteJuridico Atualizar(ClienteJuridico entidade)
        {
            return _clienteDAO.Atualizar(entidade);
        }

        public ClienteJuridico BuscarPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IList<ClienteJuridico> BuscarTodos()
        {
            return _clienteDAO.BuscarTodos();
        }

        public void Deletar(ClienteJuridico entidade)
        {
            _clienteDAO.Deletar(entidade);
        }
    }
}
