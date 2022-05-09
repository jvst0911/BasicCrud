using System;
using System.Collections.Generic;

namespace BasicCrud.Core.Entities.Mock
{
    public class PessoaMock
    {
        public static List<Pessoa> _pessoas = new List<Pessoa>
        {
            new Pessoa { Nome = "João Vitor de Souza Tomio", Idade = 20, CPF = "125.563.299-20", DtNascimento = DateTime.Parse("09-11-2001"), Email = "joao.tomio@catolicasc.org.br", Telefone = "47996073978"},
        };
    }
}
