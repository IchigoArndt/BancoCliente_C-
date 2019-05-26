using bancoCliente.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.Base
{
   public interface IDAO <T> where T:Entidade
    {
        T Adicionar(T entidade);
        T Atualizar(T entidade);
        void Deletar(T entidade);
        IList<T> BuscarTodos();
        T BuscarPorId(long id);
    }
}
