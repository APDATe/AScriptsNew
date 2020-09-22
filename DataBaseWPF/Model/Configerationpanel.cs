using SQLite.CodeFirst;

namespace DataBaseWPF.Model
{
   public class ConfigerationPanel
    {
            [Autoincrement]
            public int Id { get; set; }
            public string Name { get; set; }
            public string ParentId { get; set; }
    }
}
