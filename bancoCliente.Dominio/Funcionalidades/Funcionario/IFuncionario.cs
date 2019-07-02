using bancoCliente.Dominio.Base;
using bancoCliente.Dominio.Funcionalidades.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.IFuncionarios
{
    public class IFuncionario : IRepositorio<Funcionario>
    {
        public bool Atualizar(Funcionario entidade)
        {
            throw new NotImplementedException();
        }

        public bool Deletar(Funcionario entidade)
        {
            throw new NotImplementedException();
        }

        public Funcionario Inserir(Funcionario entidade)
        {
            throw new NotImplementedException();
        }

        public Funcionario PegarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Funcionario> PegarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
