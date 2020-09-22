using DataBaseWPF.Model;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace DataBaseWPF.Context
{
    public class CPContext : DbContext
    {
        public DbSet<ConfigerationPanel> ConfigerationPanels { get; set; }
        public CPContext() : base("MyContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var sqliteInitializer = new SqliteCreateDatabaseIfNotExists<CPContext>(modelBuilder);
            Database.SetInitializer(sqliteInitializer);
        }
    }
}
