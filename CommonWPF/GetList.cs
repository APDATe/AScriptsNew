using DataBaseWPF.Context;
using DataBaseWPF.Model;
using System.Collections.Generic;
using System.Linq;

namespace CommonWPF
{
    public class GetList
    {
        public List<ConfigerationPanel> GetLists()
        {
           var context = new CPContext();

            return context.ConfigerationPanels.Local.ToList();
        }
    }
}
