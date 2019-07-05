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
    public class EmpresaServico : EmpresaDAO
    {

        EmpresaDAO _repositorioCliente = new EmpresaDAO();

        public Empresa Inserir(Empresa entidade)
        {
            return _repositorioCliente.Adicionar(entidade);
        }

        public Empresa Atualizar(Empresa entidade)
        {
            return _repositorioCliente.Atualizar(entidade);
        }

        public long PegarPorId(int id)
        {
            return _repositorioCliente.ObterUltimoId();
        }

        public int Deletar(Empresa entidade)
        {
            int id = Convert.ToInt32(entidade.Id.ToString());
            int retorno = _repositorioCliente.Excluir(id);
            _repositorioCliente.ExcluirEndereco(entidade.IdEndereco);
            return retorno;
        }

        public IList<Empresa> PegarTodos()
        {
            return _repositorioCliente.ObterTodosItens();
        }
    }
}
