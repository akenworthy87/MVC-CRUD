using Microsoft.EntityFrameworkCore;
using MVC_CRUD.Models;

namespace MVC_CRUD.Data
{
    public class MVC_CRUDContext : DbContext
    {
        public MVC_CRUDContext(DbContextOptions<MVC_CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<Issue> Issue { get; set; }
        public DbSet<Severity> Severity { get; set; }
    }
}