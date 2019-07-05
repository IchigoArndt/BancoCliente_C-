using bancoCliente.Dominio.Funcionalidades.Empresas;
using BancoCliente.Infra.BancoDados.Enderecos;
using BancoCliente.Infra.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoempresaDominio.Infra.BancoDados.Empresas
{
     public class EmpresaDAO : IDAO<Empresa>
     {
         #region Queries
         private string Insert = @"INSERT INTO TBEmpresa (RazaoSocial,NomeFantasia,CNPJ,DataFundacao,Telefone,Email,IdEndereco) 
                                   VALUES (@razaoSocial,@nomeFantasia,@cnpj,@dataFundacao,@telefone,@email,@idEndereco)
)";
         private string GetAll = @"SELECT * FROM TBEmpresa ORDER BY Id";
         private string GetById = @"SELECT * FROM TBEmpresa WHERE Id = @id";
         private string Delete = @"DELETE FROM TBEmpresa WHERE id = @id";
        private string Update = @"UPDATE TBEmpresa SET 
                                   RazaoSocial = @razaoSocial,
                                   NomeFantasia = @nomeFantasia,
                                   CNPJ = @cnpj,
                                   DataFundacao = @dataFundacao,
                                   Telefone = @telefone,
                                   Email = @email where Id = @id";
         private const string GetLastOne = @"SELECT top(1) * FROM TBEmpresa ORDER BY Id DESC";
        #endregion

        EnderecoDAO endereco = new EnderecoDAO();

        public Empresa Adicionar(Empresa Empresa)
         {

            var end = endereco.Adicionar(Empresa.Endereco);

            Empresa.Endereco = end;

            Empresa.IdEndereco = Convert.ToInt32(end.Id.ToString());

            DB.Add(Insert, GetParam(Empresa));

             int id = ObterUltimoId();

             Empresa.Id = id;

             return Empresa;
         }

         public int ObterUltimoId()
         {
             int id = 0;
             IList<Empresa> Empresas = DB.GetAll(GetLastOne, Converter);

             foreach (var item in Empresas)
             {
                 id = item.Id;
             }

             return id;
         }

         public Empresa Atualizar(Empresa Empresa)
        {
            var end = endereco.Atualizar(Empresa.Endereco);

            Empresa.Endereco = end;


            DB.Update(Update, GetParam(Empresa));

             return Empresa;
         }

         public int Excluir(int EmpresaId)
         {
             var dic = new Dictionary<string, object>();
             dic.Add("Id", EmpresaId);

             DB.Delete(Delete, dic);

             return EmpresaId;
         }

        public void ExcluirEndereco(int id)
        {
            endereco.Excluir(id);
        }


        public IList<Empresa> ObterTodosItens()
         {
            IList<Empresa> clientes = DB.GetAll(GetAll, Converter);
            foreach (var item in clientes)
            {
                item.Endereco = endereco.PegarPorId(item.IdEndereco);
            }
            return clientes;
        }

         private static Empresa Converter(IDataReader _reader)
         {
             Empresa Empresa = new Empresa();

             Empresa.Id = Convert.ToInt32(_reader["Id"]);
             Empresa.RazaoSocial = Convert.ToString(_reader["RazaoSocial"]);
             Empresa.NomeFantasia = Convert.ToString(_reader["NomeFantasia"]);
             Empresa.Cnpj = Convert.ToString(_reader["CNPJ"]);
             Empresa.DataFund = Convert.ToDateTime(_reader["DataFundacao"]);
             Empresa.Telefone = Convert.ToString(_reader["Telefone"]);
             Empresa.Email = Convert.ToString(_reader["Email"]);
             Empresa.IdEndereco = Convert.ToInt32(_reader["IdEndereco"]);

            return Empresa;
         }

         public Dictionary<string, object> GetParam(Empresa Empresa)
         {
             var dic = new Dictionary<string, object>();
             dic.Add("Id", Empresa.Id);
             dic.Add("RazaoSocial", Empresa.RazaoSocial);
             dic.Add("NomeFantasia", Empresa.NomeFantasia);
             dic.Add("CNPJ", Empresa.Cnpj);
             dic.Add("DataFundacao", Empresa.DataFund);
             dic.Add("Telefone", Empresa.Telefone);
             dic.Add("Email", Empresa.Email);
             dic.Add("IdEndereco", Empresa.IdEndereco);
            return dic;
         }
     }
     
}
