using CommunityToolkit.Mvvm.ComponentModel;
using KigooPCMauiSimple.Models;
using KigooPCMauiSimple.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using KigooPCMauiSimple.KigooTask;
using KigooPCMauiSimple.Views;

namespace KigooPCMauiSimple.ViewModels.AppViewModel
{



  public partial class PropertiesViewModel : BasePageViewModel
  {
     

    public PropertiesViewModel()
    {
      this.properties = GetProperties().Result;
    }


    

    [ObservableProperty]
    ObservableCollection<Property> properties;

    [ObservableProperty]
    Property selectedItem;


    [ObservableProperty]
    public string searchTerm;


    [RelayCommand]
    public void SearchName()
    {



      if (string.IsNullOrEmpty(searchTerm))
      {
        searchTerm = string.Empty;
        
      }
      else
      {
        var zeSource = GetProperties().Result;
        searchTerm = searchTerm.ToLowerInvariant();
        var fiteredItems = zeSource.Where(m =>
        m.Name.ToLowerInvariant().Contains(searchTerm)
        || m.Address.ToLowerInvariant().Contains(searchTerm));

          
            properties.Clear();
          

          foreach (var item in fiteredItems)
          {
            properties.Add(item);
          }

        

      }





    }



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
      await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
        new Dictionary<string, object>()
        {
          {"PropertyDetailViewModel",detail }
        }

        );
    }



    public static async Task<ObservableCollection<Property>> GetProperties()
    {
      var homeviewModel = await new PropertiesService().GetUserPropertiesViewModelAsync();

      var properties = new ObservableCollection<Property>();
      foreach (var item in homeviewModel.Properties)
      {
        properties.Add(item);
      }

      return properties;
    }

  }


}
