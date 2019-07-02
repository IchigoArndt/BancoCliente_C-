using bancoCliente.Dominio.Base;
using bancoCliente.Dominio.Funcionalidades.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.IContas
{
    public class IConta : IRepositorio<ContaDominio>
    {
        public bool Atualizar(ContaDominio entidade)
        {
            throw new NotImplementedException();
        }

        public bool Deletar(ContaDominio entidade)
        {
            throw new NotImplementedException();
        }

        public ContaDominio Inserir(ContaDominio entidade)
        {
            throw new NotImplementedException();
        }

        public ContaDominio PegarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ContaDominio> PegarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
