using bancoCliente.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoCliente.Dominio.Funcionalidades.Conta
{
   public class Conta : Entidade
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

        private int _id;
        private float _taxaManutencao;
        private string _agencia;
        private int _tipoConta;

        public override void Validar()
        {
            throw new NotImplementedException();
        }
        public List<string> Contas
        {
            get { return Tipos_contas; }
        } 
        public string agencia
        {
            get { return _agencia; }
            set { _agencia = agencia; }
        } 
        public float taxaManutencao
        {
            get { return _taxaManutencao; }
            set { _taxaManutencao = taxaManutencao; }
        }
        public int tipoConta
        {
            get { return _tipoConta; }
            set { _tipoConta = tipoConta; }
        }
        public int id
        {
            get { return _id; }
            set { _id = id; }
        }

    }
}
