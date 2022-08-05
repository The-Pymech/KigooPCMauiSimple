using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigooPCMauiSimple.ViewModels.AppViewModel
{
  public partial class BasePageViewModel : ObservableObject
  {

    public BasePageViewModel()
    {
      isNotBusy = !IsBusy;
    }

    [ObservableProperty]
    public bool isBusy;


    [ObservableProperty]
    public bool isNotBusy;


    [ObservableProperty]
    public string pageTitle;
    



  }
}
