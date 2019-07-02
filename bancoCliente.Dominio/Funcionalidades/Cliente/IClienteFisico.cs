using bancoCliente.Dominio.Base;
using bancoCliente.Dominio.Funcionalidades.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.IClienteFisico
{
    public class IClienteFisico
    {
        //public ClienteFisicoRepositorio _clienteRepositorio = new ClienteFisicoRepositorio();

        public bool Atualizar(ClienteFisico entidade)
        {
            throw new NotImplementedException();
        }

        public bool Deletar(ClienteFisico entidade)
        {
            throw new NotImplementedException();
        }

        public ClienteFisico Inserir(ClienteFisico entidade)
        {
            throw new NotImplementedException();
        }

        public ClienteFisico PegarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ClienteFisico> PegarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
