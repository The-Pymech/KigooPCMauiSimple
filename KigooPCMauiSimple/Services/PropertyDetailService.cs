using KigooPCMauiSimple.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KigooPCMauiSimple.Services
{
  public class PropertyDetailService
  {
    
  


    public async Task<PropertyDetailViewModel> GetPropertyDetailAsync(int Id)
    {
      var convertedResponse = new PropertyDetailViewModel();
      using ( var client = new HttpClient())
      {
        client.DefaultRequestHeaders.Accept.Clear();
        client.BaseAddress = new Uri("https://api.kigoo.properties/");
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        

        try
        {
           var response =  client.GetAsync($"api/MobileAppAPI/PropertyDetail?Id={Id}").Result;
        var responseAsString = await response.Content.ReadAsStringAsync();
        convertedResponse = JsonConvert.DeserializeObject<PropertyDetailViewModel>(responseAsString);
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
