using BasicCrud.Core.Entities;
using BasicCrud.Core.Entities.Mock;
using System;
using System.ComponentModel;
using System.Linq;
using Xunit;

namespace BasicCrud.Tests.Tests
{
    public class PessoaTest
    {
        [Fact]
        [Description("O método deve retornar uma exception quando o nome for nulo ou vazio")]
        public void Pessoa_ShouldThrowException_WhenHaveEmptyOrNullName()
        {
            var pessoa = new Pessoa()
            {
                Idade = 20,
                CPF = "125.563.299-20",
                DtNascimento = DateTime.Parse("09-11-2001"),
                Email = "joao.tomio@catolicasc.org.br",
                Telefone = "47996073978"
            };

            var exp = Assert.Throws<Exception>(() => pessoa.Validate());

            Assert.Equal("Nome inválido", exp.Message);
        }
        [Fact]
        [Description("O método deve retornar uma exception quando o email for nulo ou vazio")]
        public void Pessoa_ShouldThrowException_WhenHaveEmptyOrNullEmail()
        {
            var pessoa = new Pessoa()
            {
                Nome = "João Vitor de Souza Tomio",
                Idade = 20,
                CPF = "125.563.299-20",
                DtNascimento = DateTime.Parse("09-11-2001"),
                Telefone = "47996073978"
            };

            var exp = Assert.Throws<Exception>(() => pessoa.Validate());

            Assert.Equal("Email inválido", exp.Message);
        }
        [Fact]
        [Description("O método deve retornar uma exception quando o telefone for nulo ou vazio")]
        public void Pessoa_ShouldThrowException_WhenHaveEmptyOrNullTelefone()
        {
            var pessoa = new Pessoa()
            {
                Nome = "João Vitor de Souza Tomio",
                Idade = 20,
                CPF = "125.563.299-20",
                DtNascimento = DateTime.Parse("09-11-2001"),
                Email = "joao.tomio@catolicasc.org.br"
            };

            var exp = Assert.Throws<Exception>(() => pessoa.Validate());

            Assert.Equal("Telefone inválido", exp.Message);
        }
        [Fact]
        [Description("O método deve retornar uma exception quando o cpf for nulo ou vazio")]
        public void Pessoa_ShouldThrowException_WhenHaveEmptyOrNullCPF()
        {
            var pessoa = new Pessoa()
            {
                Nome = "João Vitor de Souza Tomio",
                Idade = 20,
                DtNascimento = DateTime.Parse("09-11-2001"),
                Email = "joao.tomio@catolicasc.org.br",
                Telefone = "47996073978"
            };

            var exp = Assert.Throws<Exception>(() => pessoa.Validate());

            Assert.Equal("CPF inválido", exp.Message);
        }
        [Fact]
        [Description("O método deve retornar uma exception quando o cpf for maior que 11 caractéres")]
        public void Pessoa_ShouldThrowException_WhenHaveCpfLengthDifferentThan11()
        {
            var pessoa = new Pessoa()
            {
                Nome = "João Vitor de Souza Tomio",
                Idade = 20,
                DtNascimento = DateTime.Parse("09-11-2001"),
                Email = "joao.tomio@catolicasc.org.br",
                CPF = "125563299201",
                Telefone = "47996073978"
            };

            var exp = Assert.Throws<Exception>(() => pessoa.Validate());

            Assert.Equal("CPF inválido", exp.Message);
        }

        [Fact]
        [Description("O método deve retornar uma exception quando a idade for menor que zero")]
        public void Pessoa_ShouldThrowException_WhenIdadeValueIsLessThanZero()
        {
            var pessoa = new Pessoa()
            {
                Nome = "João Vitor de Souza Tomio",
                Idade = -1,
                DtNascimento = DateTime.Parse("09-11-2001"),
                Email = "joao.tomio@catolicasc.org.br",
                CPF = "12556329920",
                Telefone = "47996073978"
            };

            var exp = Assert.Throws<Exception>(() => pessoa.Validate());

            Assert.Equal("Idade inválida", exp.Message);
        }

        [Fact]
        [Description("O método deve retornar uma exception quando a idade for igual a zero")]
        public void Pessoa_ShouldThrowException_WhenIdadeValueEqualsZero()
        {
            var pessoa = new Pessoa()
            {
                Nome = "João Vitor de Souza Tomio",
                Idade = 0,
                DtNascimento = DateTime.Parse("09-11-2001"),
                Email = "joao.tomio@catolicasc.org.br",
                CPF = "12556329920",
                Telefone = "47996073978"
            };

            var exp = Assert.Throws<Exception>(() => pessoa.Validate());

            Assert.Equal("Idade inválida", exp.Message);
        }
        [Fact]
        [Description("O método deve retornar sucesso quando a idade for maior que zero")]
        public void Pessoa_ShouldSucceed_WhenIdadeValueIsMoreThanZero()
        {
            var pessoa = PessoaMock._pessoas.FirstOrDefault();

            Assert.Equal(20, pessoa.Idade);
        }
    }
}
