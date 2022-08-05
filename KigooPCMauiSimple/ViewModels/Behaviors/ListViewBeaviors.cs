using KigooPCMauiSimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigooPCMauiSimple.ViewModels.Behaviors
{
  public class ListViewBeaviors : Behavior<ListView>
  {

    protected  void ItemSelected(ListView listView)
    {
      var selectedItem = listView.SelectedItem as Property;
      var propertyId = selectedItem.Id;

    }
  }
}
