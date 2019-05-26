using bancoCliente.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.Clientes
{
    public class ClienteFisico : Cliente
    {
        private string cpf;
        private int quantidadeLimite;
        private float limitePagamento;
        #region Geters and Seters
        
        public ClienteFisico()
        {
            this.endereco = new Endereco();
        }

        public string getCpf()
        {
            return cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public int getQuantidadeLimite()
        {
            return quantidadeLimite;
        }
        public void setQuantidadeLimite(int quantidadeLimite)
        {
            this.quantidadeLimite = quantidadeLimite;
        }
        public float getLimitePagamento()
        {
            return limitePagamento;
        }
        public void setLimitePagamento(float limitePagamento)
        {
            this.limitePagamento = limitePagamento;
        }
        public override void Validar()
        {
            throw new NotImplementedException();
        }
        #endregion

        public override string ToString()
        {
            return string.Format("ID:{0} CPF:{1} Nome:{2}", id, getCpf(), nome);
        }

    }
}
