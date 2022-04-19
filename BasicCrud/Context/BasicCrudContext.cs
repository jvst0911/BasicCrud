using BasicCrud.Entities;
using Microsoft.EntityFrameworkCore;

namespace BasicCrud.Context
{
    public partial class BasicCrudContext : DbContext
    {
        public BasicCrudContext(DbContextOptions<BasicCrudContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
