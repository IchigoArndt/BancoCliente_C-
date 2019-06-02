using bancoCliente.Dominio.Funcionalidades.Funcionarios;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.BancoDados.Funcionarios
{
    public class FuncionarioDAO : IDAO<Funcionario>
    {
        public static List<Funcionario> Funcionarios;
        public static Funcionario funcionario = new Funcionario();

        public Funcionario Adicionar(Funcionario entidade)
        {
            Funcionarios = BuscarTodos().ToList();
            Funcionario UltimaFuncionario = Funcionarios.Last();
            entidade.Id = UltimaFuncionario.Id + 1;
            Funcionarios.Add(entidade);
            return entidade;
        }

        public Funcionario Atualizar(Funcionario entidade)
        {
            Funcionario funcionarioDominio = Funcionarios.Find(C => C.Id == entidade.Id);
            Funcionarios.Remove(funcionarioDominio);
            funcionarioDominio.setDataNasc(entidade.getDataNasc());
            funcionarioDominio.setEmail(entidade.getEmail());
            funcionarioDominio.setEndereco(entidade.getEndereco());
            funcionarioDominio.setNome(entidade.getNome());
            funcionarioDominio.setTelefone(entidade.getTelefone());
            funcionarioDominio.CPF = entidade.CPF;
            funcionarioDominio.Id = entidade.Id;
            funcionario.Cargo = entidade.Cargo;
            funcionario.Salario = entidade.Salario;
            /////////////////////////////
            Funcionarios.Add(funcionarioDominio);
            ////////////////////////////
            return funcionarioDominio;
        }

        public Funcionario BuscarPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Funcionario> BuscarTodos()
        {
            if (Funcionarios == null)
            {
                Funcionarios = RetornaFuncionarios();

                return Funcionarios.OrderBy(E => E.Id).ToList();
            }
            else
                return Funcionarios.OrderBy(E => E.Id).ToList();
        }

        public void Deletar(Funcionario entidade)
        {
            Funcionarios.Remove(entidade);
        }

        public List<Funcionario> RetornaFuncionarios()
        {
            return DadosBase.retornaFuncionarios();
        }

    }
}
