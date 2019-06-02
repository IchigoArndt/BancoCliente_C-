using bancoCliente.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.Depositos
{
   public class Deposito
    {

        public int DiaBase
        {
            get;set;
        }

        public float Valor
        {
            get;set;
        }

       public Cliente Clientes
        {
            get;set;
        }
    }
}
