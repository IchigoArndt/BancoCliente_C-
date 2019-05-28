using bancoCliente.Dominio.Funcionalidades.Empresa;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoempresaDominio.Infra.BancoDados.Empresas
{
    public class EmpresaDAO : IDAO<Empresa>
    {
        public static List<Empresa> Empresas;
        public static Empresa empresa = new Empresa();

        public Empresa Adicionar(Empresa entidade)
        {
            Empresas = BuscarTodos().ToList();
            Empresa UltimaEmpresa = Empresas.Last();
            entidade.Id = UltimaEmpresa.Id + 1;
            Empresas.Add(entidade);
            return entidade;
        }

        public Empresa Atualizar(Empresa entidade)
        {
            Empresa empresaDominio = Empresas.Find(C => C.Id == entidade.Id);
            Empresas.Remove(empresaDominio);
            empresaDominio.DataFund = entidade.DataFund;
            empresaDominio.Email = entidade.Email;
            empresaDominio.Endereco = entidade.Endereco;
            empresaDominio.NomeFantasia = entidade.NomeFantasia;
            empresaDominio.RazaoSocial = entidade.RazaoSocial;
            empresaDominio.Telefone = entidade.Telefone;
            empresaDominio.Cnpj = entidade.Cnpj;
            empresaDominio.Id = entidade.Id;
            /////////////////////////////
            Empresas.Add(empresaDominio);
            ////////////////////////////
            return empresaDominio;
        }

        public Empresa BuscarPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Empresa> BuscarTodos()
        {
            if (Empresas == null)
            {
                Empresas = RetornaEmpresas();

                return Empresas.OrderBy(E => E.Id).ToList();
            }
            else
                return Empresas.OrderBy(E => E.Id).ToList();
        }

        public void Deletar(Empresa entidade)
        {
            Empresas.Remove(entidade);
        }

        public List<Empresa> RetornaEmpresas()
        {
            return DadosBase.retornaEmpresas();
        }

    }
}
