using KigooPCMauiSimple.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigooPCMauiSimple.ViewModels
{
  

  // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
 
  public class PropertyAmenity
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("property")]
    public Property Property { get; set; }

    [JsonProperty("propertyId")]
    public int PropertyId { get; set; }
  }

 



  public class PropertyDetailViewModel
  {
    [JsonProperty("property")]
    public Property Property { get; set; }

    [JsonProperty("propertySliders")]
    public List<PropertySlider> PropertySliders { get; set; }

    [JsonProperty("propertyAmenities")]
    public List<PropertyAmenity> PropertyAmenities { get; set; }

    [JsonProperty("agent")]
    public User Agent { get; set; }


    [JsonProperty("socialMedia")]
    public SocialMedia SocialMedia { get; set; }
  }


  public class User
  {
    [JsonProperty("lastName")]
    public string LastName { get; set; }

    [JsonProperty("middleName")]
    public string MiddleName { get; set; }

    [JsonProperty("firstName")]
    public string FirstName { get; set; }

    [JsonProperty("about")]
    public string About { get; set; }

    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("skills")]
    public object Skills { get; set; }

    [JsonProperty("quote")]
    public object Quote { get; set; }

    [JsonProperty("mobileNumber")]
    public string MobileNumber { get; set; }

    [JsonProperty("skype")]
    public object Skype { get; set; }

    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("facebookLink")]
    public string FacebookLink { get; set; }

    [JsonProperty("twitterLink")]
    public string TwitterLink { get; set; }

    [JsonProperty("instagramLink")]
    public string InstagramLink { get; set; }

    [JsonProperty("linkedInLink")]
    public object LinkedInLink { get; set; }

    [JsonProperty("imageName")]
    public string ImageName { get; set; }

    [JsonProperty("uploadedFile")]
    public object UploadedFile { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("userName")]
    public string UserName { get; set; }

    [JsonProperty("normalizedUserName")]
    public string NormalizedUserName { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("normalizedEmail")]
    public string NormalizedEmail { get; set; }

    [JsonProperty("emailConfirmed")]
    public bool EmailConfirmed { get; set; }

    [JsonProperty("passwordHash")]
    public string PasswordHash { get; set; }

    [JsonProperty("securityStamp")]
    public string SecurityStamp { get; set; }

    [JsonProperty("concurrencyStamp")]
    public string ConcurrencyStamp { get; set; }

    [JsonProperty("phoneNumber")]
    public object PhoneNumber { get; set; }

    [JsonProperty("phoneNumberConfirmed")]
    public bool PhoneNumberConfirmed { get; set; }

    [JsonProperty("twoFactorEnabled")]
    public bool TwoFactorEnabled { get; set; }

    [JsonProperty("lockoutEnd")]
    public object LockoutEnd { get; set; }

    [JsonProperty("lockoutEnabled")]
    public bool LockoutEnabled { get; set; }

    [JsonProperty("accessFailedCount")]
    public int AccessFailedCount { get; set; }
  }


}
