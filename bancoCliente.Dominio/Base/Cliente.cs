using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Base
{
    public abstract class Cliente : Pessoa
    {
        public float limite;
        public bool direitoCheque;
        public bool cartaoCredito;
        #region Geters and Seters
        public float getLimite()
        {
            return limite;
        }
        public void setLimite(float limite)
        {
            this.limite = limite;
        }
        public bool isDireitoCheque()
        {
            return direitoCheque;
        }
        public void setDireitoCheque(bool direitoCheque)
        {
            this.direitoCheque = direitoCheque;
        }
        public bool isCartaoCredito()
        {
            return cartaoCredito;
        }
        public void setCartaoCredito(bool cartaoCredito)
        {
            this.cartaoCredito = cartaoCredito;
        }
        #endregion
    }
}
