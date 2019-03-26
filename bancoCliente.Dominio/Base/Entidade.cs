using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Base
{
    public abstract class Entidade
    {
        public long Id { get; set; }
        public abstract void Validar();
    }
}
