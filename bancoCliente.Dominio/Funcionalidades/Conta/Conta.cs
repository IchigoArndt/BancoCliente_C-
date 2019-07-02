using bancoCliente.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.Conta
{
   public class ContaDominio : Entidade
    {
        public static readonly int TIPO_CONTA_POUPANCA = 0;
        public static readonly int TIPO_CONTA_CORRENTE = 1;
        public static readonly int TIPO_CONTA_SALARIO = 2;
        public static readonly int TIPO_CONTA_DIGITAL = 3;

        public static List<string> Tipos_contas = new List<string>()
        {          
           "Conta Poupança",
           "Conta Corrente",
           "Conta Sálario",
           "Conta Digital"
        };

        public int Id { get; set; }

        //public int idConta;
        //private float _taxaManutencao;
        //private string _agencia;
        //private int _tipoConta;

        public override void Validar()
        {
            throw new NotImplementedException();
        }
        public List<string> Contas
        {
            get { return Tipos_contas; }
        } 
        public string Agencia{ get; set; } 
        public float taxaManutencao { get; set; }
        public int TipoConta { get; set;}


        public List<string> retornaTipoConta()
        {
            return Tipos_contas;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}"+" Tipo Conta: {1}" + "  Descrição: {2} ",Id,TipoConta,Tipos_contas[TipoConta]);
        }
        public string RetornaDescricao()
        {
            return string.Format(Tipos_contas[TipoConta]);
        }

    }
}
