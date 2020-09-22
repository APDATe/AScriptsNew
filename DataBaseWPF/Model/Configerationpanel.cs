using SQLite.CodeFirst;

namespace DataBaseWPF.Model.ConfigerationPanelModel
{
    public class Configerationpanel
    {
        [Autoincrement]
        public string Код { get; set; }
        public string Наименование { get; set; }
        public string Артикул { get; set; }
        public decimal Цена { get; set; }
        public int Id { get; set; }
    }
}
