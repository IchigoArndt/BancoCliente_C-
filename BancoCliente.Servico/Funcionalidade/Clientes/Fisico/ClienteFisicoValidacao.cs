using bancoCliente.Dominio.Funcionalidades.Clientes;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCliente.Servico.Funcionalidade.Clientes.Fisico
{
    public class ClienteFisicoValidacao
    {
        public ClienteFisico _cliente;

        public ClienteFisicoValidacao(ClienteFisico cliente)
        {
            _cliente = cliente;
        }

        public virtual ValidationResult Validate()
        {
            return new Validator().Validate(_cliente);
        }
    }
    class Validator : AbstractValidator<ClienteFisico>
    {
        public Validator()
        {
            RuleFor(c => c.nome)
                .NotNull().NotEmpty()
                .MaximumLength(50)
                .MinimumLength(10);
            RuleFor(c => c.cpf)
                .NotEmpty().NotNull()
                .MaximumLength(12)
                .MinimumLength(12);
            RuleFor(c => c.dataNasc)
                .NotNull().LessThan(DateTime.Now);
            RuleFor(c => c.email)
                .NotEmpty().NotNull()
                .MinimumLength(5)
                .MaximumLength(20);
            RuleFor(c => c.direitoCheque)
                .NotNull().NotEmpty();
            RuleFor(c => c.cartaoCredito)
                .NotNull().NotEmpty();
            RuleFor(c => c.limite)
                .NotNull().NotEmpty()
                .GreaterThanOrEqualTo(0);
            RuleFor(c => c.limitePagamento)
               .NotNull().NotEmpty()
               .GreaterThanOrEqualTo(0);
            RuleFor(c => c.quantidadeLimite)
               .NotNull().NotEmpty()
               .GreaterThanOrEqualTo(0);
        }
    }
}
