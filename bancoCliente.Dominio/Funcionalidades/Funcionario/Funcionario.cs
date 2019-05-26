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
        private string cpf;
        private float salario;
        private string cargo;

        public override void Validar()
        {
            throw new NotImplementedException();
        }

        public string CPF
        {
            get { return cpf; }
            set
            {
                cpf = CPF;
            }
        }

        public float Salario
        {
            get
            {
                return salario;
            }
            set
            {
                salario = Salario;
            }
        }
        public string Cargo
        {
            get
            {
                return cargo;
            }
            set
            {
                cargo = Cargo;
            }
        }


    }
}
