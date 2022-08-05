using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KigooPCMauiSimple.Models;
using KigooPCMauiSimple.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigooPCMauiSimple.ViewModels.AppViewModel
{
  [QueryProperty("PropertyDetailViewModel", "PropertyDetailViewModel")]
  public partial class PropertyDetailsViewModel : BasePageViewModel
  {
   

   


    [ObservableProperty]
    PropertyDetailViewModel propertyDetailViewModel;



    



  }
}
