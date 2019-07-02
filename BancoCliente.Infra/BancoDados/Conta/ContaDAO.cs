using bancoCliente.Dominio.Funcionalidades.Conta;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.BancoDados.Conta
{
   /* public class ContaDAO : IDAO<ContaDominio>
    {
        public static List<ContaDominio> Contas;
        public static ContaDominio conta = new ContaDominio();

        public ContaDominio Adicionar(ContaDominio entidade)
        {
            Contas = BuscarTodos().ToList();
            ContaDominio conta = Contas.Last();
            entidade.Id = conta.Id + 1;
            Contas.Add(entidade);
            return entidade;
        }

        public ContaDominio Atualizar(ContaDominio entidade)
        {
            ContaDominio conta = Contas.Find(C => C.Id == entidade.Id);
            Contas.Remove(conta);
            conta.Agencia = entidade.Agencia;
            conta.Id = entidade.Id;
            conta.taxaManutencao = entidade.taxaManutencao;
            /////////////////////////////
            Contas.Add(conta);
            ////////////////////////////
            return conta;
        }

        public ContaDominio BuscarPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IList<ContaDominio> BuscarTodos()
        {
            if (Contas == null)
            {
                Contas = RetornaContas();

                return Contas;
            }
            else
                return Contas;
        }

        public void Deletar(ContaDominio entidade)
        {
            Contas.Remove(entidade);
        }

        public List<ContaDominio> RetornaContas()
        {
            return DadosBase.retornaContas();
        }

    }
    */
}
