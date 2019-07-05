using bancoCliente.Dominio.Funcionalidades.Clientes;
using BancoCliente.Infra.BancoDados.Enderecos;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.BancoDados.Cliente.Jurudico
{
    public class ClienteJuridicoDAO : IDAO<ClienteJuridico> 
    {

        EnderecoDAO endereco = new EnderecoDAO();

        #region Queries
        private string Insert = @"INSERT INTO TBClienteJuridico (Nome,Email,Limite,Cheque,Cartao,CNPJ,IdEndereco) 
                                  VALUES (@nome,@email,@limite,@cheque,@cartao,@cnpj,@idEndereco)";
        private string GetAll = @"SELECT * FROM TBClienteJuridico ORDER BY Id";
        private string GetById = @"SELECT * FROM TBClienteJuridico WHERE Id = @id";
        private string Delete = @"DELETE FROM TBClienteJuridico WHERE id = @id";
        private string Update = @"UPDATE TBClienteJuridico SET 
                                  Nome = @nome,
                                  Email = @email,
                                  Limite = @limite,
                                  Cheque = @cheque,
                                  Cartao = @cartao,
                                  CNPJ = @cnpj where Id = @id";
        private const string GetLastOne = @"SELECT top(1) * FROM TBClienteJuridico ORDER BY Id DESC";
        #endregion

        public ClienteJuridico Adicionar(ClienteJuridico ClienteJuridico)
        {

            var end = endereco.Adicionar(ClienteJuridico.endereco);

            ClienteJuridico.endereco = end;

            ClienteJuridico.IdEndereco = Convert.ToInt32(end.Id.ToString());

            DB.Add(Insert, GetParam(ClienteJuridico));

            long id = ObterUltimoId();

            ClienteJuridico.Id = id;

            return ClienteJuridico;
        }

        public long ObterUltimoId()
        {
            long id = 0;
            IList<ClienteJuridico> ClienteJuridicos = DB.GetAll(GetLastOne, Converter);

            foreach (var item in ClienteJuridicos)
            {
                id = item.Id;
            }

            return id;
        }

        public ClienteJuridico Atualizar(ClienteJuridico ClienteJuridico)
        {
            var end = endereco.Atualizar(ClienteJuridico.endereco);

            ClienteJuridico.endereco = end;

            DB.Update(Update, GetParam(ClienteJuridico));

            return ClienteJuridico;
        }

        public void ExcluirEndereco(int id)
        {
            endereco.Excluir(id);
        }

        public int Excluir(int ClienteJuridicoId)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", ClienteJuridicoId);

            DB.Delete(Delete, dic);

            return ClienteJuridicoId;
        }


        public IList<ClienteJuridico> ObterTodosItens()
        {
            IList<ClienteJuridico> clientes = DB.GetAll(GetAll, Converter);
            foreach (var item in clientes)
            {
                item.endereco = endereco.PegarPorId(item.IdEndereco);
            }
            return clientes;
        }

        private static ClienteJuridico Converter(IDataReader _reader)
        {
            ClienteJuridico ClienteJuridico = new ClienteJuridico();

            ClienteJuridico.Id = Convert.ToInt32(_reader["Id"]);
            ClienteJuridico.nome = Convert.ToString(_reader["Nome"]);
            ClienteJuridico.email = Convert.ToString(_reader["Email"]);
            ClienteJuridico.limite = float.Parse(Convert.ToString(_reader["Limite"]));
            ClienteJuridico.direitoCheque = Convert.ToBoolean(_reader["Cheque"]);
            ClienteJuridico.cartaoCredito = Convert.ToBoolean(_reader["Cartao"]);
            ClienteJuridico.cnpj = Convert.ToString(_reader["CNPJ"]);
            ClienteJuridico.IdEndereco = Convert.ToInt32(_reader["IdEndereco"]);
            //ClienteJuridico.IdConta = Convert.ToInt32(_reader["IdConta"]);
            //ClienteJuridico.IdEmpresa = Convert.ToInt32(_reader["IdEmpresa"]);

            return ClienteJuridico;
        }

        public Dictionary<string, object> GetParam(ClienteJuridico ClienteJuridico)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", ClienteJuridico.Id);
            dic.Add("Nome", ClienteJuridico.nome);
            dic.Add("Email", ClienteJuridico.email);
            dic.Add("Limite", ClienteJuridico.limite);
            dic.Add("Cheque", ClienteJuridico.direitoCheque);
            dic.Add("Cartao", ClienteJuridico.cartaoCredito);
            dic.Add("CNPJ", ClienteJuridico.cnpj);
            dic.Add("IdEndereco", ClienteJuridico.IdEndereco);
            /*dic.Add("IdConta", ClienteJuridico.IdConta);
            dic.Add("IdEmpresa", ClienteJuridico.IdEmpresa);
            */
            return dic;
        }
    }
}
