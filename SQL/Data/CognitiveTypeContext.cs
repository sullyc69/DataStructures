using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class CognitiveTypeContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Result> Results { get; set; } = null!;
        public DbSet<Models.Type> CognitiveTypes { get; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:funcogtyp-sqlsrv.database.windows.net,1433;Initial Catalog=funcogtyp_sqldb;Persist Security Info=False;User ID=funcogtype-admin;Password=Ku54r169!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
