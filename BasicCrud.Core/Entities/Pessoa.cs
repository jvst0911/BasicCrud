using System;

namespace BasicCrud.Core.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new Exception("Nome inválido");
            if (string.IsNullOrEmpty(Email))
                throw new Exception("Email inválido");
            if (string.IsNullOrEmpty(Telefone))
                throw new Exception("Telefone inválido");
            if (string.IsNullOrEmpty(CPF))
                throw new Exception("CPF inválido");
            if (CPF.Length != 11)
                throw new Exception("CPF inválido");
            if (Idade <= 0)
                throw new Exception("Idade inválida");
        }
    }
}
