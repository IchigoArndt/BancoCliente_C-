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
        private String cpf;
        private float salario;
        private String cargo;

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
