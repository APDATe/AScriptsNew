using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using System.Windows.Input;
using DataBaseWPF.Context.ConfigerationPanel;
using DataBaseWPF.Model.ConfigerationPanelModel;

namespace AS.ViewModels
{
    class CPVModel 
    {
        public ICommand GenCommand { get; set; }
        //public ICollectionView Configerationpanels { get; private set; }

        //public ICollectionView GetIdNames()
        //{
        //    //using (var context = new CPContext())
        //    //{
        //    //    context.Configerationpanels.Load();
        //    //    Configerationpanels = CollectionViewSource.GetDefaultView((List<Configerationpanel>)context.Configerationpanels.Local.ToList());
        //    //}

        //    //return Configerationpanels;
        //}
    }
}
