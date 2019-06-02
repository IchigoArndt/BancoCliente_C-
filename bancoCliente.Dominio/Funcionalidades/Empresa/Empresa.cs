using bancoCliente.Dominio.Base;
using bancoCliente.Dominio.Funcionalidades.Funcionarios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.Empresas
{
    public class Empresa : Entidade
    {
      /*private static int _Id;
        private string _razaoSocial;
        private string _nomeFantasia;
        private string _cnpj;
        private DateTime _dataFund;
        private string _telefone;
        private string _email;
        private Endereco _endereco;
        private List<Funcionario> _listaFuncionario;
      */

        #region Getters and Setters
        //Geters
        public string Telefone
        {
            get;set;
        }
        public string Email
        {
            get; set;
        }
        public int Id
        {
            get; set;
        }
        public string RazaoSocial
        {
            get; set;
        }
        public string NomeFantasia
        {
            get; set;
        }
        public string Cnpj
        {
            get; set;
        }
        public DateTime DataFund
        {
            get; set;
        }
        public Endereco Endereco
        {
            get; set;
        }
        public List<Funcionario> funcionarios
        {
            get; set;
        }

        public override void Validar()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Format("ID: {0}" + "  Razão Social: {1}" + "  CNPJ: {2}", Id, RazaoSocial, Cnpj);
        }

        #endregion
    }
}
