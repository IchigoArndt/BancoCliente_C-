using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Empresas;
using BancoempresaDominio.Infra.BancoDados.Empresas;

namespace BancoCliente.Servico.Funcionalidade.Empresas
{
    public class EmpresaServico : IEmpresaServico
    {

        EmpresaDAO _empresa = new EmpresaDAO();

        public Empresa Adicionar(Empresa entidade)
        {
           return _empresa.Adicionar(entidade);
        }

        public Empresa Atualizar(Empresa entidade)
        {
            return _empresa.Atualizar(entidade);
        }

        public Empresa BuscarPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Empresa> BuscarTodos()
        {
            return _empresa.BuscarTodos();
        }

        public void Deletar(Empresa entidade)
        {
            _empresa.Deletar(entidade);
        }
    }
}
