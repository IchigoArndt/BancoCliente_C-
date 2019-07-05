using bancoCliente.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.Funcionarios
{
    public class Funcionario : Pessoa
    {
        //private string cpf;
        //private float salario;
        //private string cargo;
        public int IdEndereco;

        public Funcionario()
        {
            endereco = new Endereco();
        }
        
        public override void Validar()
        {
            throw new NotImplementedException();
        }

        public string CPF{ get; set; }

        public float Salario
        {
            get;set;
        }
        public string Cargo
        {
            get;set;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}" + "  Nome: {1}" + " CPF: {2}", Id, getNome(), CPF);
        }

    }
}
