using bancoCliente.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.Clientes
{
    public class ClienteJuridico : Cliente
    {
        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
