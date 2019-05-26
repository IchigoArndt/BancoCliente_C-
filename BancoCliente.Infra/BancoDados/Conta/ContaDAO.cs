using bancoCliente.Dominio.Funcionalidades.Conta;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.BancoDados.Conta
{
    public class ContaDAO : IDAO<ContaDominio>
    {
        public static List<ContaDominio> Contas;
        public static ContaDominio conta = new ContaDominio();

        public ContaDominio Adicionar(ContaDominio entidade)
        {
            throw new NotImplementedException();
        }

        public ContaDominio Atualizar(ContaDominio entidade)
        {
            throw new NotImplementedException();
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

        public IList<string> retornaTipoContas()
        {
            return conta.retornaTipoConta();
        }

        public void Deletar(ContaDominio entidade)
        {
            throw new NotImplementedException();
        }

        public List<ContaDominio> RetornaContas()
        {
            return DadosBase.retornaContas();
        }

    }
}
