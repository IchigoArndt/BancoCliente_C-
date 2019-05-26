using bancoCliente.Dominio.Funcionalidades.Clientes;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.BancoDados.Cliente.Fisico
{
    public class ClienteFisicoDAO : IDAO<ClienteFisico>
    {

        public static List<ClienteFisico> ClientesFiscos;

        public ClienteFisico Adicionar(ClienteFisico entidade)
        {
            ClientesFiscos.Add(entidade);
            ClienteFisico cliente = ClientesFiscos.Last();
            entidade.id = cliente.id + 1;
            return entidade;
        }

        public ClienteFisico Atualizar(ClienteFisico entidade)
        {
            ClienteFisico cliente = ClientesFiscos.Find(C => C.id == entidade.id);
            ClientesFiscos.Remove(cliente);
            cliente.dataNasc = entidade.dataNasc;
            cliente.email = entidade.email;
            cliente.endereco = entidade.endereco;
            cliente.nome = entidade.nome;
            cliente.telefone = entidade.telefone;
            cliente.setCartaoCredito(entidade.isCartaoCredito());
            cliente.setDireitoCheque(entidade.isDireitoCheque());
            cliente.setCpf(entidade.getCpf());
            cliente.setLimite(entidade.getLimite());
            cliente.setLimitePagamento(entidade.getLimitePagamento());
            cliente.setQuantidadeLimite(entidade.getQuantidadeLimite());
            cliente.setId(entidade.getId());
            /////////////////////////////
            ClientesFiscos.Add(cliente);
            ////////////////////////////
            return cliente;
        }

        public ClienteFisico BuscarPorId(long id)
        {
            return ClientesFiscos.Find(C => C.id == id);
        }

        public IList<ClienteFisico> BuscarTodos()
        {
            if (ClientesFiscos == null)
            {
                ClientesFiscos = RetornaClientes();

                return ClientesFiscos;
            }
            else
                return ClientesFiscos;
        }

        public void Deletar(ClienteFisico entidade)
        {
            ClientesFiscos.Remove(entidade);
        }

        public List<ClienteFisico> RetornaClientes()
        {
            return DadosBase.retornaClientesFisicos();
        }
    }
}
