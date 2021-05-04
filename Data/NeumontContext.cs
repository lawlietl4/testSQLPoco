using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testSQLPoco.Models;

namespace testSQLPoco.Data
{
    class NeumontContext : DbContext
    {
        private readonly string host = "localhost";
        private readonly string db = "NeumontClass";
        private readonly string username = "neumontuser";
        private readonly string password = "neumontpassword";
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql($"Host={host};Database={db};Username={username};Password={password};");
    }
}
