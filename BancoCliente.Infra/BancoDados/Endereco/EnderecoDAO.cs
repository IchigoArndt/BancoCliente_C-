using bancoCliente.Dominio.Base;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.BancoDados.Enderecos
{
    public class EnderecoDAO : IDAO<Endereco>
    {
        #region Queries
        private string Insert = @"INSERT INTO TBEndereco (logradouro,numero,complemento,bairro,cidade,uf) 
                                   VALUES (@logradouro,@numero,@complemento,@bairro,@cidade,@uf)";
        private string GetAll = @"SELECT * FROM TBEndereco ORDER BY Id";
        private string GetById = @"SELECT * FROM TBEndereco WHERE Id = @id";
        private string Delete = @"DELETE FROM TBEndereco WHERE id = @id";
        private string Update = @"UPDATE TBEndereco SET 
                                   logradouro = @logradouro,
                                   numero = @numero,
                                   complemento = @complemento,
                                   bairro = @bairro,
                                   cidade = @cidade,
                                   uf = @uf";
        private const string GetLastOne = @"SELECT top(1) * FROM TBEndereco ORDER BY Id DESC";
        #endregion

        public Endereco Adicionar(Endereco Endereco)
        {
            DB.Add(Insert, GetParam(Endereco));

            int id = ObterUltimoId();

            Endereco.Id = id;

            return Endereco;
        }

        public int ObterUltimoId()
        {
            long id = 0;
            IList<Endereco> Enderecos = DB.GetAll(GetLastOne, Converter);

            foreach (var item in Enderecos)
            {
                id = item.Id;
            }

            return Convert.ToInt32(id.ToString());
        }

        public Endereco Atualizar(Endereco Endereco)
        {
            DB.Update(Update, GetParam(Endereco));

            return Endereco;
        }

        public int Excluir(int EnderecoId)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", EnderecoId);

            DB.Delete(Delete, dic);

            return EnderecoId;
        }


        public IList<Endereco> ObterTodosItens()
        {
            return DB.GetAll(GetAll, Converter);
        }

        public Endereco PegarPorId(int id)
        {
            return DB.GetById(GetById,Converter,new Dictionary<string, object>() { {"Id",id} });
        }


        private static Endereco Converter(IDataReader _reader)
        {
            Endereco Endereco = new Endereco();

            Endereco.Id = Convert.ToInt32(_reader["Id"]);
            Endereco.logradouro = Convert.ToString(_reader["logradouro"]);
            Endereco.numero = Convert.ToInt32(_reader["numero"]);
            Endereco.complemento = Convert.ToString(_reader["complemento"]);
            Endereco.bairro = Convert.ToString(_reader["bairro"]);
            Endereco.cidade = Convert.ToString(_reader["cidade"]);
            Endereco.uf = Convert.ToInt32(_reader["uf"]);

            return Endereco;
        }

        public Dictionary<string, object> GetParam(Endereco Endereco)
        {
            var dic = new Dictionary<string, object>();
            //dic.Add("Id", Endereco.Id);
            dic.Add("logradouro", Endereco.logradouro);
            dic.Add("numero", Endereco.numero);
            dic.Add("complemento", Endereco.complemento);
            dic.Add("bairro", Endereco.bairro);
            dic.Add("cidade", Endereco.cidade);
            dic.Add("uf", Endereco.uf);

            return dic;
        }
    }
}
