using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Clientes;

namespace BancoCliente.Servico.Funcionalidade.Clientes.Fisico
{
    public class ClienteFisicoServico : IClienteFisicoServico
    {

        public ClienteFisico Adicionar(ClienteFisico entidade)
        {
            return null;
        }

        public ClienteFisico Atualizar(ClienteFisico entidade)
        {
            throw new NotImplementedException();
        }

        public ClienteFisico BuscarPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IList<ClienteFisico> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Deletar(ClienteFisico entidade)
        {
            throw new NotImplementedException();
        }
    }
}
