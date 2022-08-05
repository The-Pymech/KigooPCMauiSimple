using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KigooPCMauiSimple.Models;

namespace KigooPCMauiSimple.ViewModels
{
  // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);




  public class UserPropertiesViewModel
  {
    [JsonProperty("properties")]
    public List<Property> Properties { get; set; }

    [JsonProperty("filterOption")]
    public int FilterOption { get; set; }

    [JsonProperty("generalQuery")]
    public object GeneralQuery { get; set; }

    [JsonProperty("socialMedia")]
    public SocialMedia SocialMedia { get; set; }
  }



}
