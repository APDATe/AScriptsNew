﻿using AS.Commands;
using CommonWPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Data;
using System.Windows.Input;

namespace AS.ViewModels
{
    public class MainViewModel
    {
        public ICollectionView Configerationpanels { get; private set; }

        public ICommand TestCommand { get; set; }
        
        public MainViewModel()
        {
            var context = new GetList();
     
               // context.Configerationpanels.Load();
                Configerationpanels = CollectionViewSource.GetDefaultView(context.GetLists());

            TestCommand = new Command(x => Test());
        }

        private void Test()
        {
            //не понятно почему не обновляются данные в гриде (
            //using (var context = new CPContext())
            //{
            //    context.Configerationpanels.Load();
            //    var ggg = context.Configerationpanels.Local;
            //    Configerationpanels = CollectionViewSource.GetDefaultView((List<Configerationpanel>)ggg.ToList());
            //}
            //Configerationpanels.Refresh();

            //CPVModel model = new CPVModel();
            ////здесь нет но и логик ане верная (
            //Configerationpanels =  model.GetIdNames();

        }
    }
}
