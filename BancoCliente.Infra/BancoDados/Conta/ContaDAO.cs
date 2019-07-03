using bancoCliente.Dominio.Funcionalidades.Conta;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.BancoDados.Conta
{
   public class ContaDAO : IDAO<ContaDominio>
    {
        #region Queries
        private string Insert = @"INSERT INTO TBConta (Id,Agencia,TaxaManutencao,TipoConta) 
                                  VALUES (@id,@agencia,@TaxaManutencao,@tipoConta)";
        private string GetAll = @"SELECT * FROM TBConta ORDER BY Id";
        private string GetById = @"SELECT * FROM TBConta WHERE Id = @id";
        private string Delete = @"DELETE FROM TBConta WHERE id = @id";
        private string Update = @"UPDATE TBConta SET 
                                  Agencia = @agencia,
                                  TaxaManutencao = @TaxaManutencao,
                                  tipoConta = @tipoConta";
        private const string GetLastOne = @"SELECT top(1) * FROM TBConta ORDER BY Id DESC";
        #endregion

        public ContaDominio Adicionar(ContaDominio ContaDominio)
        {
            DB.Add(Insert, GetParam(ContaDominio));

            int id = ObterUltimoId();

            ContaDominio.Id = id;

            return ContaDominio;
        }

        public int ObterUltimoId()
        {
            int id = 0;
            IList<ContaDominio> ContaDominios = DB.GetAll(GetLastOne, Converter);

            foreach (var item in ContaDominios)
            {
                id = item.Id;
            }

            return id;
        }

        public ContaDominio Atualizar(ContaDominio ContaDominio)
        {
            DB.Update(Update, GetParam(ContaDominio));

            return ContaDominio;
        }

        public int Excluir(int ContaDominioId)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", ContaDominioId);

            DB.Delete(Delete, dic);

            return ContaDominioId;
        }


        public IList<ContaDominio> ObterTodosItens()
        {
            return DB.GetAll(GetAll, Converter);
        }

        private static ContaDominio Converter(IDataReader _reader)
        {
            ContaDominio ContaDominio = new ContaDominio();

            ContaDominio.Id = Convert.ToInt32(_reader["Id"]);
            ContaDominio.Agencia = Convert.ToString(_reader["Agencia"]);
            ContaDominio.taxaManutencao = float.Parse(Convert.ToString(_reader["TaxaManutencao"]));
            ContaDominio.TipoConta = Convert.ToInt16(_reader["TipoConta"]);

            return ContaDominio;
        }

        public Dictionary<string, object> GetParam(ContaDominio ContaDominio)
        {
            var dic = new Dictionary<string, object>();
            dic.Add("Id", ContaDominio.Id);
            dic.Add("Agencia", ContaDominio.Agencia);
            dic.Add("TaxaManutencao", ContaDominio.taxaManutencao);
            dic.Add("TipoConta", ContaDominio.TipoConta);
            
            return dic;
        }
    }
    
}
