using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KigooPCMauiSimple.Services
{



  public class RestService
  {
    

    public HttpClient GetRestService()
    {
      using (var client = new HttpClient())
      {
        client.DefaultRequestHeaders.Accept.Clear();
        //client.BaseAddress = new Uri("https://api.kigoo.properties/api/");
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        return client;
      }
    }

    
  }
}
