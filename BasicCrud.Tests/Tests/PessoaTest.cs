using BasicCrud.Core.Entities;
using System;
using System.ComponentModel;
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
    }
}
