using SQLiteSample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Common
{
  public class GetList
    {
        public List<Phone> GetLists()
        {
           var context = new DataContext();


            return context.Phones.Local.ToList();
        }
    }
}
