using DevJr.CrudClient.Infra.Database.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevJr.CrudClient.Infra.Database
{
    public class AppContexto : DbContext
    {
        public AppContexto()
        {
        }

        public AppContexto(DbContextOptions<AppContexto> options) : base(options)
        { }
        public DbSet<Pessoa> Pessoas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source='127.0.0.1,1433';User Id=sa;Password=mypassword@@aabbcc123;Initial Catalog=CrudClient;");
            //optionsBuilder.UseSqlServer(@"Data Source='database,1433';User Id=sa;Password=mypassword@@aabbcc123;Initial Catalog=CrudClient;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Pessoa>().HasIndex(b => b.Cpf).IsUnique();
        }
    }

}