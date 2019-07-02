using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Base
{
   public interface IRepositorio<T>where T: Entidade
    {
        T Inserir(T entidade);
        bool Atualizar(T entidade);
        bool Deletar(T entidade);
        IQueryable<T> PegarTodos();
        T PegarPorId(int id);
    }
}
