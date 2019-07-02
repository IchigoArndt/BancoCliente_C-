using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Clientes;
using bancoCliente.Dominio.Funcionalidades.IClienteFisico;
using BancoCliente.Infra.BancoDados.Cliente.Fisico;
using BancoCliente.Infra.Contexto;
using BancoCliente.Infra.Funcionalidades.ClienteFisicosReposiorios;

namespace BancoCliente.Servico.Funcionalidade.Clientes.Fisico
{
    public class ClienteFisicoServico : IClienteFisicoServico
    {
        //ClienteFisicoDAO _repositorioCliente = new ClienteFisicoDAO();

       public static BancoClienteContexto _contexto = new BancoClienteContexto();

        private readonly ClienteFisicoRepositorio _repositorioCliente = new ClienteFisicoRepositorio(_contexto) ;

        public ClienteFisico Inserir (ClienteFisico entidade)
        {
            return _repositorioCliente.Inserir(entidade);
        }

        public bool Atualizar(ClienteFisico entidade)
        {
            return _repositorioCliente.Atualizar(entidade);
        }

        public ClienteFisico PegarPorId(int id)
        {
            return _repositorioCliente.PegarPorId(id);
        }

        public bool Deletar(ClienteFisico entidade)
        {
            return _repositorioCliente.Deletar(entidade.id);
        }

        public IQueryable<ClienteFisico> PegarTodos()
        {
            return _repositorioCliente.PegarTodos();
        }
    }
}
