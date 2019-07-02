using bancoCliente.Dominio.Base;
using bancoCliente.Dominio.Funcionalidades.Empresas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.IEmpresas
{
    public class IEmpresa : IRepositorio<Empresa>
    {
        public bool Atualizar(Empresa entidade)
        {
            throw new NotImplementedException();
        }

        public bool Deletar(Empresa entidade)
        {
            throw new NotImplementedException();
        }

        public Empresa Inserir(Empresa entidade)
        {
            throw new NotImplementedException();
        }

        public Empresa PegarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Empresa> PegarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
