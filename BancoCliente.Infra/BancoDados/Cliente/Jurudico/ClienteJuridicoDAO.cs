using bancoCliente.Dominio.Funcionalidades.Clientes;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.BancoDados.Cliente.Jurudico
{
    public class ClienteJuridicoDAO : IDAO<ClienteJuridico> 
    {
        public static List<ClienteJuridico> ClientesJuridicos;

        public ClienteJuridico Adicionar(ClienteJuridico entidade)
        {
            ClientesJuridicos = BuscarTodos().ToList();
            ClienteJuridico cliente = ClientesJuridicos.Last();
            entidade.id = cliente.id + 1;
            ClientesJuridicos.Add(entidade);
            return entidade;
        }

        public ClienteJuridico Atualizar(ClienteJuridico entidade)
        {
            ClienteJuridico cliente = ClientesJuridicos.Find(C => C.id == entidade.id);
            ClientesJuridicos.Remove(cliente);
            cliente.dataNasc = entidade.dataNasc;
            cliente.email = entidade.email;
            cliente.endereco = entidade.endereco;
            cliente.nome = entidade.nome;
            cliente.telefone = entidade.telefone;
            cliente.setCartaoCredito(entidade.isCartaoCredito());
            cliente.setDireitoCheque(entidade.isDireitoCheque());
            cliente.setCnpj(entidade.getCnpj());
            cliente.setLimite(entidade.getLimite());
            cliente.setId(entidade.getId());
            /////////////////////////////
            ClientesJuridicos.Add(cliente);
            ////////////////////////////
            return cliente;
        }

        public ClienteJuridico BuscarPorId(long id)
        {
            return ClientesJuridicos.Find(C => C.id == id);
        }

        public IList<ClienteJuridico> BuscarTodos()
        {
            if (ClientesJuridicos == null)
            {
                ClientesJuridicos = RetornaClientes();

                return ClientesJuridicos;
            }
            else
                return ClientesJuridicos;
        }

        public void Deletar(ClienteJuridico entidade)
        {
            ClientesJuridicos.Remove(entidade);
        }
        public List<ClienteJuridico> RetornaClientes()
        {
            return DadosBase.retornaClientesJuridicos();
        }
    }
}
