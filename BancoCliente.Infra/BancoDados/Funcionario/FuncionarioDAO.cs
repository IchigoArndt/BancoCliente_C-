using bancoCliente.Dominio.Funcionalidades.Funcionarios;
using BancoCliente.Infra.BancoDados.Enderecos;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.BancoDados.Funcionarios
{
    
    public class FuncionarioDAO : IDAO<Funcionario>
    {
        #region Queries
        private string Insert = @"INSERT INTO TBFuncionario (Nome,Telefone,Email,DataNasc,CPF,Cargo,Salario,IdEndereco) 
                                   VALUES (@nome,@telefone,@email,@dataNasc,@cpf,@cargo,@salario,@idEndereco)";
        private string GetAll = @"SELECT * FROM TBFuncionario ORDER BY Id";
        private string GetById = @"SELECT * FROM TBFuncionario WHERE Id = @id";
        private string Delete = @"DELETE FROM TBFuncionario WHERE id = @id";
        private string Update = @"UPDATE TBFuncionario SET 
                                   Nome = @nome,
                                   Telefone = @telefone,
                                   Email = @email,
                                   DataNasc = @dataNasc,
                                   CPF = @cpf,
                                   Cargo = @cargo,
                                   Salario = @salario";
        private const string GetLastOne = @"SELECT top(1) * FROM TBFuncionario ORDER BY Id DESC";
        #endregion

        EnderecoDAO endereco = new EnderecoDAO();

        public Funcionario Adicionar(Funcionario Funcionario)
        {

            var end = endereco.Adicionar(Funcionario.endereco);

            Funcionario.endereco = end;

            Funcionario.IdEndereco = Convert.ToInt32(end.Id.ToString());


            DB.Add(Insert, GetParam(Funcionario));

            int id = ObterUltimoId();

            Funcionario.Id = id;

            return Funcionario;
        }

        public int ObterUltimoId()
        {
            long id = 0;
            IList<Funcionario> Funcionarios = DB.GetAll(GetLastOne, Converter);

            foreach (var item in Funcionarios)
            {
                id = item.Id;
            }

            return Convert.ToInt32(id.ToString());
        }

        public Funcionario Atualizar(Funcionario Funcionario)
        {
            var end = endereco.Atualizar(Funcionario.endereco);

            Funcionario.endereco = end;

            DB.Update(Update, GetParam(Funcionario));

            return Funcionario;
        }

        public int Excluir(int FuncionarioId)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", FuncionarioId);

            DB.Delete(Delete, dic);

            return FuncionarioId;
        }

        public void ExcluirEndereco(int id)
        {
            endereco.Excluir(id);
        }


        public IList<Funcionario> ObterTodosItens()
        {
            IList<Funcionario> clientes = DB.GetAll(GetAll, Converter);
            foreach (var item in clientes)
            {
                item.endereco = endereco.PegarPorId(item.IdEndereco);
            }
            return clientes;
        }

        private static Funcionario Converter(IDataReader _reader)
        {
            Funcionario Funcionario = new Funcionario();

            Funcionario.Id = Convert.ToInt32(_reader["Id"]);
            Funcionario.nome = Convert.ToString(_reader["Nome"]);
            Funcionario.telefone = Convert.ToString(_reader["Telefone"]);
            Funcionario.email = Convert.ToString(_reader["Email"]);
            Funcionario.dataNasc = Convert.ToDateTime(_reader["DataNasc"]);
            Funcionario.CPF = Convert.ToString(_reader["CPF"]);
            Funcionario.Cargo = Convert.ToString(_reader["Cargo"]);
            Funcionario.Salario = float.Parse(Convert.ToString(_reader["Salario"]));
            Funcionario.IdEndereco = Convert.ToInt32(_reader["IdEndereco"]);

            return Funcionario;
        }

        public Dictionary<string, object> GetParam(Funcionario Funcionario)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", Funcionario.Id);
            dic.Add("Nome", Funcionario.nome);
            dic.Add("Telefone", Funcionario.telefone);
            dic.Add("Email", Funcionario.email);
            dic.Add("DataNasc", Funcionario.dataNasc);
            dic.Add("CPF", Funcionario.CPF);
            dic.Add("Cargo", Funcionario.Cargo);
            dic.Add("Salario", Funcionario.Salario);
            dic.Add("IdEndereco", Funcionario.IdEndereco);
            return dic;
        }
    }
    
}
