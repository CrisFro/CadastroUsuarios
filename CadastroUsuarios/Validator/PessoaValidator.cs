using CadastroUsuarios.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarios.Validator
{

    //Tentativa de criar uma validação para o usuário
    public class PessoaValidator: AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Email obrigatório").EmailAddress().WithMessage("E-mail com formato inválido");

        }
    }
}
