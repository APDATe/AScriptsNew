using DataBaseWPF.Context.ConfigerationPanel;
using DataBaseWPF.Model.ConfigerationPanelModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace DataBaseWPF
{
  public class GetCP
    {
        public List<Configerationpanel> Get_()
        {
            CPContext context;
            using (context = new CPContext())
            {
                context.Configerationpanels.Load();
            }

            return  context.Configerationpanels.Local.ToList();
        }
    }
}
