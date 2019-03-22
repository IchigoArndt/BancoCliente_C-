using bancoCliente.Dominio.Base;
using bancoCliente.Dominio.Funcionalidades.Funcionarios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.Empresa
{
    public class Empresa
    {
        private static int Id;
        private String razaoSocial;
        private String nomeFantasia;
        private String cnpj;
        private GregorianCalendar dataFund;
        private String telefone;
        private String email;
        private Endereco endereco;
        private List<Funcionario> listaFuncionario;

        #region Getters and Setters
        //Geters
        public String getTelefone()
        {
            return telefone;
        }
        public String getEmail()
        {
            return email;
        }
        public int getId()
        {
            return Id;
        }
        public String getRazaoSocial()
        {
            return razaoSocial;
        }
        public String getNomeFantasia()
        {
            return nomeFantasia;
        }
        public String getCnpj()
        {
            return cnpj;
        }
        public GregorianCalendar getDataFund()
        {
            return dataFund;
        }
        public Endereco getEndereco()
        {
            return endereco;
        }

        // set Id
        public void setId(int id)
        {
            Id = id;
        }

        public String setRazaoSocial(String razao)
        {
            return this.razaoSocial = razao;
        }
        public String setNomeFantasia(String Nome)
        {
            return nomeFantasia = Nome;
        }
        public String setCnpj(String cnpj)
        {
            return cnpj = cnpj;
        }
        public GregorianCalendar setDataFund(GregorianCalendar data)
        {
            return dataFund = data;
        }
        public String setTelefone(String telefone)
        {
            return telefone = telefone;
        }
        public String setEmail(String Email)
        {
            return email = Email;
        }
        public Endereco setEndereco(Endereco endereco2)
        {
            return endereco = endereco2;
        }
        #endregion
    }
}
