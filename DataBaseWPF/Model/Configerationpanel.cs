using SQLite.CodeFirst;

namespace DataBaseWPF.Model.ConfigerationPanelModel
{
    public class Configerationpanel
    {
        [Autoincrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
    }
}
