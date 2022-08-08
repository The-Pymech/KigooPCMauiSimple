using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KigooPCMauiSimple.Models;
using KigooPCMauiSimple.Services;
using System.Threading;
using System.Collections.ObjectModel;
using KigooPCMauiSimple.Views;
using KigooPCMauiSimple.KigooTask;

namespace KigooPCMauiSimple.ViewModels.AppViewModel
{

  //[INotifyPropertyChanged]
  public partial class HomeViewModel : BasePageViewModel
  {
    public HomeViewModel()
    {
      this.isBusy = true;
      this.slider = GetData.GetSliders();
      this.latestProperty =  GetData.GetProperties().Result;
      this.isBusy = false;
    }



    [ObservableProperty]
     ObservableCollection<HomePageSliders> slider;

    [ObservableProperty]
    ObservableCollection<Property> latestProperty;

    [RelayCommand]
    async Task GoToDetails(Property property)
    {
      if (property is null)
      {
        return;
      }
      var detail = GetData.GetPropertyDetail(property.Id).Result;
      var description = Converters.HTMLToText(detail.Property.Description);
      detail.Property.Description = description;
      await Shell.Current.GoToAsync($"{nameof(DetailsPage)}",true,
        new Dictionary<string, object>()
        {
          {"PropertyDetailViewModel",detail }
        }

        );
    }
   
  }


 

  public class GetData
  {


    public static ObservableCollection<HomePageSliders> GetSliders()
    {
      var sliders = new ObservableCollection<HomePageSliders>();
      sliders.Add(new HomePageSliders { Id = 1, ImageName = "https://kigoo.properties/Sliders/1.png" });
      sliders.Add(new HomePageSliders { Id = 2, ImageName = "https://kigoo.properties/Sliders/2.png" });
      sliders.Add(new HomePageSliders { Id = 3, ImageName = "https://kigoo.properties/Sliders/3.png" });
      sliders.Add(new HomePageSliders { Id = 4, ImageName = "https://kigoo.properties/Sliders/4.png" });

      return sliders;
    }

    public static async Task<ObservableCollection<Property>> GetProperties()
    {
      var homeviewModel = await new HomeService().GetUserHomeViewModelAsync();

      var properties = new ObservableCollection<Property>();
      foreach (var item in homeviewModel.LatestProperties)
      {
        properties.Add(item);
      }

      return properties;
    }

    public static async Task<PropertyDetailViewModel> GetPropertyDetail(int Id)
    {
      var vm = await new PropertyDetailService().GetPropertyDetailAsync(Id);

      return vm;
    }



  }
}
