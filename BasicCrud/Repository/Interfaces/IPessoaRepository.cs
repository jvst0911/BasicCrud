using BasicCrud.Entities;
using System.Collections.Generic;

namespace BasicCrud.Repository.Interface
{
    public interface IPessoaRepository
    {
        List<Pessoa> GetAll();
        Pessoa GetById(int id);
        int Insert(Pessoa entity);
        int Update(Pessoa entity);
        int Delete(int id);
    }
}