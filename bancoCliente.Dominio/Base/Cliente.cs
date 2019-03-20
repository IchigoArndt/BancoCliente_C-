using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Base
{
    public abstract class Cliente : Pessoa
    {
        private int tipoConta;
        private float limite;
        private Boolean direitoCheque;
        private Boolean cartaoCredito;
        #region Geters and Seters
        public int getTipoConta()
        {
            return tipoConta;
        }
        public void setTipoConta(int tipoConta)
        {
            this.tipoConta = tipoConta;
        }
        public float getLimite()
        {
            return limite;
        }
        public void setLimite(float limite)
        {
            this.limite = limite;
        }
        public Boolean isDireitoCheque()
        {
            return direitoCheque;
        }
        public void setDireitoCheque(Boolean direitoCheque)
        {
            this.direitoCheque = direitoCheque;
        }
        public Boolean isCartaoCredito()
        {
            return cartaoCredito;
        }
        public void setCartaoCredito(Boolean cartaoCredito)
        {
            this.cartaoCredito = cartaoCredito;
        }
        #endregion
    }
}
