using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Clientes;
using BancoCliente.Infra.BancoDados.Cliente.Fisico;

namespace BancoCliente.Servico.Funcionalidade.Clientes.Fisico
{
    public class ClienteFisicoServico : IClienteFisicoServico
    {
        ClienteFisicoDAO _clienteDAO = new ClienteFisicoDAO();

        public ClienteFisico Adicionar(ClienteFisico entidade)
        {
            return _clienteDAO.Adicionar(entidade);
        }

        public ClienteFisico Atualizar(ClienteFisico entidade)
        {
            return _clienteDAO.Atualizar(entidade);
        }

        public ClienteFisico BuscarPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IList<ClienteFisico> BuscarTodos()
        {
            return _clienteDAO.BuscarTodos();
        }

        public void Deletar(ClienteFisico entidade)
        {
            _clienteDAO.Deletar(entidade);
        }
    }
}
