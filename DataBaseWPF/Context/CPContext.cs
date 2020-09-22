using DataBaseWPF.Model.ConfigerationPanelModel;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace DataBaseWPF.Context.ConfigerationPanel
{
    public class CPContext : DbContext
    {
        public DbSet<Configerationpanel> Configerationpanels { get; set; }
        public CPContext() : base("DefaultConnection") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var sqliteInitializer = new SqliteCreateDatabaseIfNotExists<CPContext>(modelBuilder);
            Database.SetInitializer(sqliteInitializer);
        }
    }
}
