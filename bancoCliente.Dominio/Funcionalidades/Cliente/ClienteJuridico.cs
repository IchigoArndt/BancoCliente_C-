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


        public ClienteJuridico()
        {
            endereco = new Endereco();
        }

        public override void Validar()
        {
            throw new NotImplementedException();
        }

        private string cnpj;

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
            return string.Format("ID: {0}" + " Nome: {1}" + " CNPJ: {2}", getId(), getNome(), getCnpj());
        }

    }
}
