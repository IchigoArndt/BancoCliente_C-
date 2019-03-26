using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Base
{

    public abstract class Pessoa : Entidade
    {
        public int id;
        public String nome;
        public Endereco endereco;
        public String telefone;
        public String email;
        public DateTime dataNasc;

        #region Geters and Seters
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public String getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public Endereco getEndereco()
        {
            return endereco;
        }
        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }
        public String getTelefone()
        {
            return telefone;
        }
        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }
        public String getEmail()
        {
            return email;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public DateTime getDataNasc()
        {
            return dataNasc;
        }
        public void setDataNasc(DateTime dataNasc)
        {
            this.dataNasc = dataNasc;
        }
        #endregion

        public String getIdade()
        {
            DateTime atual = new DateTime();

            int anos = atual.Year - dataNasc.Year;
            int dias = atual.Day - dataNasc.Day;
            int meses = atual.Month - dataNasc.Month;

            String resultado = "A idade desta pessoa é :" + "\n" + anos.ToString() + " Anos" + "\n" + dias.ToString() + " Dias" + "\n" + meses.ToString() + " Meses" + "\n";

            return resultado;
        }
    }
}
