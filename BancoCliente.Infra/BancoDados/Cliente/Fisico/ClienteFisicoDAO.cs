using bancoCliente.Dominio.Funcionalidades.Clientes;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.BancoDados.Cliente.Fisico
{
    public class ClienteFisicoDAO : IDAO<ClienteFisico>
    {
        #region Queries
        private string Insert = @"INSERT INTO TBClienteFisico (Id,Nome,Email,DataNasc,Limite,Cheque,Cartao,CPF,LimitePagamento,QuantidadePagamento,IdConta) 
                                  VALUES (@id,@nome,@email,@data,@limite,@cheque,@cartao,@cpf,@limiteP,@quantidadeP,@idConta)";
        private string GetAll = @"SELECT * FROM TBClienteFisico ORDER BY Id";
        private string GetById = @"SELECT * FROM TBClienteFisico WHERE Id = @id";
        private string Delete = @"DELETE FROM TBClienteFisico WHERE id = @id";
        private string Update = @"UPDATE TBClienteFisico SET 
                                  Nome = @nome,
                                  Email = @email,
                                  DataNasc = @data,
                                  Limite = @limite,
                                  Cheque = @cheque,
                                  Cartao = @cartao,
                                  CPF = @cpf,
                                  LimitePagamento = @limiteP,
                                  QuantidadePagamento = @quantidadeP,
                                  IdConta = @idConta";
        private const string GetLastOne = @"SELECT top(1) * FROM TBClienteFisico ORDER BY Id DESC";
        #endregion

        public ClienteFisico Adicionar(ClienteFisico ClienteFisico)
        {
            DB.Add(Insert, GetParam(ClienteFisico));

            long id = ObterUltimoId();

            ClienteFisico.Id = id;

            return ClienteFisico;
        }

        public long ObterUltimoId()
        {
            long id = 0;
            IList<ClienteFisico> ClienteFisicos = DB.GetAll(GetLastOne, Converter);

            foreach (var item in ClienteFisicos)
            {
                id = item.Id;
            }

            return id;
        }

        public ClienteFisico Atualizar(ClienteFisico ClienteFisico)
        {
            DB.Update(Update, GetParam(ClienteFisico));

            return ClienteFisico;
        }

        public int Excluir(int ClienteFisicoId)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", ClienteFisicoId);

            DB.Delete(Delete, dic);

            return ClienteFisicoId;
        }

       
        public IList<ClienteFisico> ObterTodosItens()
        {
            return DB.GetAll(GetAll, Converter);
        }

        private static ClienteFisico Converter(IDataReader _reader)
        {
            ClienteFisico ClienteFisico = new ClienteFisico();

            ClienteFisico.Id = Convert.ToInt32(_reader["Id"]);
            ClienteFisico.nome = Convert.ToString(_reader["Nome"]);
            ClienteFisico.email = Convert.ToString(_reader["Email"]);
            ClienteFisico.dataNasc = Convert.ToDateTime(_reader["DataNasc"]);
            ClienteFisico.limite = float.Parse(Convert.ToString(_reader["Limite"]));
            ClienteFisico.direitoCheque = Convert.ToBoolean(_reader["Cheque"]);
            ClienteFisico.cartaoCredito = Convert.ToBoolean(_reader["Cartao"]);
            ClienteFisico.cpf = Convert.ToString(_reader["CPF"]);
            ClienteFisico.limitePagamento = float.Parse(Convert.ToString(_reader["LimitePagamento"]));
            ClienteFisico.quantidadeLimite = Convert.ToInt32(_reader["QuantidadePagamento"]);
            ClienteFisico.IdConta = Convert.ToInt32(_reader["IdConta"]);

            return ClienteFisico;
        }

        public Dictionary<string, object> GetParam(ClienteFisico ClienteFisico)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", ClienteFisico.Id);
            dic.Add("Nome", ClienteFisico.nome);
            dic.Add("Email", ClienteFisico.email);
            dic.Add("Limite", ClienteFisico.limite);
            dic.Add("Cheque", ClienteFisico.direitoCheque);
            dic.Add("Cartao", ClienteFisico.cartaoCredito);
            dic.Add("CPF", ClienteFisico.cpf);
            dic.Add("LimitePagamento", ClienteFisico.limitePagamento);
            dic.Add("QuantidadePagamento", ClienteFisico.quantidadeLimite);
            dic.Add("IdConta", ClienteFisico.IdConta);

            return dic;
        }

       
    }
}
