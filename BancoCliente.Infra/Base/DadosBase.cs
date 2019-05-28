using bancoCliente.Dominio.Base;
using bancoCliente.Dominio.Funcionalidades.Clientes;
using bancoCliente.Dominio.Funcionalidades.Conta;
using bancoCliente.Dominio.Funcionalidades.Empresa;
using bancoCliente.Dominio.Funcionalidades.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Infra.Base
{
    public static class DadosBase
    {
        public static List<ClienteFisico> clientesFisicos;
        public static List<ClienteJuridico> clienteJuridicos;
        public static List<ContaDominio> contasCadastradas;
        public static List<Empresa> empresas;
        public static List<Funcionario> funcionarios;
        private static Endereco RetornaEndereco()
        {
            Endereco endereco = new Endereco();
            endereco.setBairro("Santa Catarina");
            endereco.setCidade("Lages");
            endereco.setComplemento("Casa");
            endereco.setLongradouro("Rua Francisco lima e silva");
            endereco.setNumero(218);
            endereco.setUf(42);

            return endereco;
        }
        public static List<ClienteFisico> retornaClientesFisicos()
        {
            clientesFisicos = new List<ClienteFisico>();

            ClienteFisico cliente1 = new ClienteFisico
            {
                email = "ichigoArndt@gmail.com",
                id = 1,
                nome = "João",
                telefone = "32230583",
                endereco = RetornaEndereco(),
                dataNasc = Convert.ToDateTime("03/08/1998")
            };
            cliente1.setCpf("0000022211231");
            cliente1.setLimite(100);
            cliente1.setLimitePagamento(2000);
            cliente1.setQuantidadeLimite(300);
            ClienteFisico cliente2 = new ClienteFisico
            {
                email = "ichigoArndt@gmail.com",
                id = 2,
                nome = "Bruna",
                telefone = "32231585",
                endereco = RetornaEndereco(),
                dataNasc = Convert.ToDateTime("24/12/2000")
            };
            cliente2.setCpf("21212121232311");
            cliente1.setLimite(100);
            cliente1.setLimitePagamento(2000);
            cliente1.setQuantidadeLimite(300);
            clientesFisicos.Add(cliente1);
            clientesFisicos.Add(cliente2);

            return clientesFisicos;
        }
        public static List<ClienteJuridico> retornaClientesJuridicos()
        {

            clienteJuridicos = new List<ClienteJuridico>();

            ClienteJuridico cliente1 = new ClienteJuridico
            {
                dataNasc = Convert.ToDateTime("02/08/1900"),
                email = "EmpresaFake@gmail.com",
                endereco = RetornaEndereco(),
                id = 1,
                nome = "Empresa Fake",
                telefone = "32230486"
            };
            cliente1.setCnpj("03208444000105");
            cliente1.setLimite(1000);

            ClienteJuridico cliente2 = new ClienteJuridico
            {
                dataNasc = Convert.ToDateTime("02/08/1950"),
                email = "EmpresaFake2@gmail.com",
                endereco = RetornaEndereco(),
                id = 2,
                nome = "Empresa Fake Falsa",
                telefone = "32220486"
            };
            cliente2.setCnpj("38301094000101");
            cliente2.setLimite(2000);

            clienteJuridicos.Add(cliente1);
            clienteJuridicos.Add(cliente2);

            return clienteJuridicos;
        }
        public static List<ContaDominio> retornaContas()
        {
            contasCadastradas = new List<ContaDominio>();

            ContaDominio conta1 = new ContaDominio
            {
                Agencia = "0002220",
                Id = 1,
                taxaManutencao = 50,
                TipoConta = 0,
            };
            ContaDominio conta2 = new ContaDominio
            {
                Agencia = "0062430",
                Id = 2,
                taxaManutencao = 30,
                TipoConta = 2,
            };
            contasCadastradas.Add(conta1);
            contasCadastradas.Add(conta2);

            return contasCadastradas.OrderBy(C => C.Id).ToList();
        }
        public static List<Empresa> retornaEmpresas()
        {
            Empresa empresa1 = new Empresa
            {
                Cnpj = "37774472000101",
                DataFund = Convert.ToDateTime("23/05/1930"),
                Email = "EmpresaFalsa@gmail.com",
                Endereco = RetornaEndereco(),
                Id = 1,
                NomeFantasia = "Empresa Original",
                RazaoSocial = "Empresa Falsa",
                Telefone = "32210453",
                funcionarios = retornaFuncionarios()
            };
            Empresa empresa2 = new Empresa
            {
                Cnpj = "37774472000101",
                DataFund = Convert.ToDateTime("23/10/1955"),
                Email = "EmpresaFalsaFake@gmail.com",
                Endereco = RetornaEndereco(),
                Id = 2,
                NomeFantasia = "Empresa Cópia Original",
                RazaoSocial = "Empresa Falsa Original",
                Telefone = "31210353",
                funcionarios = retornaFuncionarios()
            };
            empresas.Add(empresa1);
            empresas.Add(empresa2);
            return empresas;
        }
        public static List<Funcionario> retornaFuncionarios()
        {
            Funcionario func1 = new Funcionario
            {
                Cargo = "Testador",
                CPF = "04189331031",
                id = 1,
                email = "Testador1@gmail.com",
                dataNasc = Convert.ToDateTime("03/08/1997"),
                endereco = RetornaEndereco(),
                nome = "TesterDev",
                telefone = "03321",
                Salario = 1300
            };
            Funcionario func2 = new Funcionario
            {
                Cargo = "Desenvolvedor",
                CPF = "04169531031",
                id = 2,
                email = "Dev1@gmail.com",
                dataNasc = Convert.ToDateTime("03/08/1990"),
                endereco = RetornaEndereco(),
                nome = "DevFullStack",
                telefone = "03321",
                Salario = 1300
            };
            funcionarios.Add(func1);
            funcionarios.Add(func2);
            return funcionarios;
        }
    }
}
