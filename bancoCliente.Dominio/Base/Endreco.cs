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
        private String logradouro;
        private int numero;
        private String complemento;
        private String bairro;
        private String cidade;
        private EnumUfs enumUf;
        private int uf;
        #region
        public String getLongradouro()
        {
            return logradouro;
        }
        public int getNumero()
        {
            return numero;
        }
        public String getComplemento()
        {
            return complemento;
        }
        public String getBairro()
        {
            return bairro;
        }
        public String getCidade()
        {
            return cidade;
        }
        public int getUf()
        {
            return uf;
        }
        //
        public String setLongradouro(String Longradouro)
        {
            return logradouro = Longradouro;
        }
        public int setNumero(int Numero)
        {
            return numero = Numero;
        }
        public String setComplemento(String Complemento)
        {
            return complemento = Complemento;
        }
        public String setBairro(String Bairro)
        {
            return bairro = Bairro;
        }
        public String setCidade(String Cidade)
        {
            return cidade = Cidade;
        }
        public int setUf(int UF)
        {
            enumUf = (EnumUfs)Enum.Parse(typeof(EnumUfs),uf.ToString());

            return uf = UF;
        }
        #endregion
        public String toString()
        {
            return "Rua:" + this.logradouro + "\n" + "Numero" + numero + "\n" + "Bairro :" + this.bairro + "\n" + "Cidade :" + this.cidade + "\n" + "Complemento :" + this.complemento + "\n" + "UF :" + this.enumUf;
        }
    }
}
