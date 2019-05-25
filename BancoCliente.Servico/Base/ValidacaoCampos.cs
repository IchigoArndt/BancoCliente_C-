using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BancoCliente.Servico.Base
{
    public static class ValidacaoCampos
    {
        public static bool isValid = false;
        #region validações Gerais
        public static bool ValidarString(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return isValid;
            if (texto.Length > 50)
                return isValid;
            if (texto.Equals(""))
                return isValid;

            return isValid = true;
        }
        public static bool ValidarNumeros(string texto)
        {
                if (!string.IsNullOrEmpty(texto))
                {
                    Regex r = new Regex(@"[^\d]");
                    if (!r.IsMatch(texto))
                        isValid = true;
                }
                return isValid;
        }
        public static bool ValidarEmail(string texto)
        {
            if (!texto.Contains("@") && !texto.Contains(".com"))
                return isValid;
            return isValid = true;
        }
        public static bool ValidarData(DateTime texto)
        {
            if (texto != null)
            {
                DateTime DataNasc = Convert.ToDateTime(texto);
                int anoMinino = 1919;
                //int anoMaximo = 2120;
                if (DataNasc.Year <= anoMinino)
                    return isValid;
                else if (DataNasc.Year >= DateTime.Now.Year)
                    return isValid;
            }
            else
                return isValid;
            ///////////
            return isValid = true;
        }
        #endregion
    }
}
