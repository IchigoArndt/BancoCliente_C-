using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.Conta
{
   public class Conta
    {
        public static readonly int TIPO_CONTA_POUPANCA = 0;
        public static readonly int TIPO_CONTA_CORRENTE = 1;
        public static readonly int TIPO_CONTA_SALARIO = 2;
        public static readonly int TIPO_CONTA_DIGITAL = 3;

        public static List<string> Tipos_contas = new List<string>()
        {
           "Conta Corrente",
           "Conta Poupança",
           "Conta Sálario",
           "Conta Digital"
        };

        private int id;
        private float taxaManutencao;
        private String agencia;
        private int tipoConta;

    }
}
