﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bancoCliente.Dominio.Funcionalidades.Conta;
using BancoCliente.Infra.BancoDados.Conta;

namespace BancoCliente.Servico.Funcionalidade.Contas
{
    public class ContaServico : IContaServico
    {

        ContaDAO _conta = new ContaDAO();

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
            return _conta.BuscarTodos();
        }

        public void Deletar(ContaDominio entidade)
        {
            throw new NotImplementedException();
        }

        public IList<string> retornaTipoConta()
        {
            return _conta.retornaTipoContas();
        }

    }
}
