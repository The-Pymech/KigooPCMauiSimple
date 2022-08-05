using KigooPCMauiSimple.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KigooPCMauiSimple.Services
{
  public class PropertiesService
  {
    public async Task<UserPropertiesViewModel> GetUserPropertiesViewModelAsync()
    {
      var convertedResponse = new UserPropertiesViewModel();
      using (var client = new HttpClient())
      {
        client.DefaultRequestHeaders.Accept.Clear();
        client.BaseAddress = new Uri("https://api.kigoo.properties/");
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        try
        {
          var response = client.GetAsync("api/MobileAppAPI/Properties").Result;
          var responseAsString = await response.Content.ReadAsStringAsync();
          convertedResponse = JsonConvert.DeserializeObject<UserPropertiesViewModel>(responseAsString);
        }
        catch (Exception e)
        {

          throw;
        }

      }

      return convertedResponse;

    }
  }
}
