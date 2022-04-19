using BasicCrud.Context;
using BasicCrud.Entities;
using BasicCrud.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace BasicCrud.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly BasicCrudContext _conn;

        public PessoaRepository(BasicCrudContext conn)
        {
            _conn = conn;
        }

        public int Delete(int id)
        {
            var pessoa = _conn.Pessoa.Find(id);
            if (pessoa != null)
            {
                _conn.Remove(pessoa);
                _conn.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public List<Pessoa> GetAll()
        {
            return _conn.Pessoa.ToList();
        }

        public Pessoa GetById(int id)
        {
            return _conn.Pessoa.Find(id);
        }

        public int Insert(Pessoa pessoa)
        {
            _conn.Pessoa.Add(pessoa);
            var result = _conn.SaveChanges();
            return result;
        }

        public int Update(Pessoa pessoa)
        {
            var temp = _conn.Pessoa.SingleOrDefault(p => p.Id == pessoa.Id);
            if (string.IsNullOrEmpty(pessoa.Nome))
                temp.Nome = pessoa.Nome;
            
            var result = _conn.SaveChanges();
            return result;
        }
    }
}