using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ControlDigit
{
    public abstract class LibraEntities : DbContext
    {
        public LibraEntities(string connectionString)
            : base(connectionString)
        {
        }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
