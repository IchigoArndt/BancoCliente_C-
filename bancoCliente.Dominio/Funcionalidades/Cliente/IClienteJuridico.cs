using bancoCliente.Dominio.Base;
using bancoCliente.Dominio.Funcionalidades.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.IClienteJuridico
{
    public class IClienteJuridico : IRepositorio<ClienteJuridico>
    {
        public bool Atualizar(ClienteJuridico entidade)
        {
            throw new NotImplementedException();
        }

        public bool Deletar(ClienteJuridico entidade)
        {
            throw new NotImplementedException();
        }

        public ClienteJuridico Inserir(ClienteJuridico entidade)
        {
            throw new NotImplementedException();
        }

        public ClienteJuridico PegarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ClienteJuridico> PegarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
