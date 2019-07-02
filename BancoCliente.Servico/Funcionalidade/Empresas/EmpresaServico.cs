using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Empresas;
using bancoCliente.Dominio.Funcionalidades.IEmpresas;
using BancoempresaDominio.Infra.BancoDados.Empresas;

namespace BancoCliente.Servico.Funcionalidade.Empresas
{
    public class EmpresaServico : IEmpresaServico
    {

        EmpresaDAO _empresa = new EmpresaDAO();

        private readonly IEmpresa _repositorioEmpresa;

        public Empresa Inserir(Empresa entidade)
        {
           return _repositorioEmpresa.Inserir(entidade);
        }

        public bool Atualizar(Empresa entidade)
        {
            return _repositorioEmpresa.Atualizar(entidade);
        }

        public Empresa PegarPorId(int id)
        {
            return _repositorioEmpresa.PegarPorId(id);
        }

        public IQueryable<Empresa> PegarTodos()
        {
            return _repositorioEmpresa.PegarTodos();
        }

        public bool Deletar(Empresa entidade)
        {
            return _repositorioEmpresa.Deletar(entidade);
        }
    }
}
