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
    public class Empresa : Entidade
    {
        private static int _Id;
        private string _razaoSocial;
        private string _nomeFantasia;
        private string _cnpj;
        private DateTime _dataFund;
        private string _telefone;
        private string _email;
        private Endereco _endereco;
        private List<Funcionario> _listaFuncionario;

        #region Getters and Setters
        //Geters
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = Telefone; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = Email; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = Id; }
        }
        public string RazaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = RazaoSocial; }
        }
        public string NomeFantasia
        {
            get { return _nomeFantasia; }
            set { _nomeFantasia = NomeFantasia; }
        }
        public string Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = Cnpj; }
        }
        public DateTime DataFund
        {
            get { return _dataFund; }
            set { _dataFund = DataFund; }
        }
        public Endereco Endereco
        {
            get { return _endereco; }
            set { _endereco = Endereco; }
        }
        public List<Funcionario> funcionarios
        {
            get { return _listaFuncionario; }
            set { _listaFuncionario = funcionarios; }
        }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
