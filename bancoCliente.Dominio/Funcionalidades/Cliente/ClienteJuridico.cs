using bancoCliente.Dominio.Base;
using bancoCliente.Dominio.Funcionalidades.Conta;
using bancoCliente.Dominio.Funcionalidades.Empresas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.Clientes
{
    public class ClienteJuridico : Cliente
    {
        public int IdConta;
        public int IdEmpresa;
        public virtual ContaDominio conta { get; set; }
        public virtual Empresa empresa { get; set; }

        public void setConta(ContaDominio Conta)
        {
            conta = Conta;
        }

        public ContaDominio getConta()
        {
            return conta;
        }

        public ClienteJuridico()
        {
            endereco = new Endereco();
            conta = new ContaDominio();
        }

        public override void Validar()
        {
            throw new NotImplementedException();
        }

        public string cnpj;

        public string getCnpj()
        {
            return cnpj;
        }

        public void setCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }


        public override string ToString()
        {
            return string.Format("ID: {0}" + " Nome: {1}" + " CNPJ: {2}", Id, getNome(), getCnpj());
        }

    }
}
