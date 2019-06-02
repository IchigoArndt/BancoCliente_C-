using bancoCliente.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Base
{
    public class Endereco
    {
        private int id;
        private string logradouro;
        private int numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private EnumUfs enumUf;
        private int uf;
        #region
        public string getLongradouro()
        {
            return logradouro;
        }
        public int getNumero()
        {
            return numero;
        }
        public string getComplemento()
        {
            return complemento;
        }
        public string getBairro()
        {
            return bairro;
        }
        public string getCidade()
        {
            return cidade;
        }
        public EnumUfs getUf()
        {
            return enumUf;
        }
        //
        public string setLongradouro(string Longradouro)
        {
            return logradouro = Longradouro;
        }
        public int setNumero(int Numero)
        {
            return numero = Numero;
        }
        public string setComplemento(string Complemento)
        {
            return complemento = Complemento;
        }
        public string setBairro(string Bairro)
        {
            return bairro = Bairro;
        }
        public string setCidade(string Cidade)
        {
            return cidade = Cidade;
        }
        public EnumUfs setUf(EnumUfs uf)
        {
            enumUf = uf;

            return uf = enumUf;
        }

        #endregion
        public override string ToString()
        {
            return string.Format("Rua:" + this.logradouro + "\n" + "Numero" + numero + "\n" + "Bairro :" + this.bairro + "\n" + "Cidade :" + this.cidade + "\n" + "Complemento :" + this.complemento + "\n" + "UF :" + this.enumUf);
        }
    }
}
