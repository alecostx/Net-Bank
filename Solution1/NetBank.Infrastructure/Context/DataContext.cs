using Microsoft.EntityFrameworkCore;
using NetBank.Domain.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBank.Infrastructure.Context
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:netbank.database.windows.net;Database=netbank;" +
                " User Id=netbank;Password=netadmin123!;Trusted_Connection=False;Encrypt=True");
        }
        public DbSet<User> Users { get; set; }

    }
}
