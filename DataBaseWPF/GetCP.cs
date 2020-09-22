using DataBaseWPF.Context;
using DataBaseWPF.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace DataBaseWPF
{
  public class GetCP
    {
        public List<ConfigerationPanel> Get_()
        {
            CPContext context;
            using (context = new CPContext())
            {
                context.ConfigerationPanels.Load();
            }

            return  context.ConfigerationPanels.Local.ToList();
        }
    }
}
