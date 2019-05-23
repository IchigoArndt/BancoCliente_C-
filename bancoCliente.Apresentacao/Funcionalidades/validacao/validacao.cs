using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bancoCliente.Apresentacao.Funcionalidades.validacao
{
    public class Validacao
    {
        bool isValid = false;
        //Valida se o numero possiu somente um numeros digitados
        public bool ValidaNumero(string campo)
        {
            
            if (!string.IsNullOrEmpty(campo))
            {
                Regex r = new Regex(@"[^\d]");
                if (!r.IsMatch(campo))
                    isValid = true;
            }
            return isValid;
        }
        public bool validaLimitCaracter(string campo)
        {
            if (campo.Length >= 3)
                isValid = true;
            return isValid;
        }
        public bool validaNumeroVirgula(string campo)
        {
            for (int i = 0; i < campo.Length; i++)
            {
                bool primeira = false;
                int numeroInt = 0;
                int numeroQue = 0;
                if (campo[i].Equals(",") && primeira == true)
                {
                    primeira = true;
                }
                if (primeira == true)
                    isValid = false;
                else
                    isValid = true;
            }

            return isValid;
        }
    }
}
