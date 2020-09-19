using KRIS.database.entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRIS.database
{
    class DBCtx : DbContext
    {
        public DBCtx() : base("DBConn") { }

        public DbSet<Users> Users { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Logs> Logs { get; set; }

        public DbSet<Counterparty> Counterparty { get; set; }
        public DbSet<CounterpartyAttrs> CounterpartyAttrs { get; set; }
        public DbSet<Dictionary> Dictionary { get; set; }
        public DbSet<Entity> Entity { get; set; }

    }
}
