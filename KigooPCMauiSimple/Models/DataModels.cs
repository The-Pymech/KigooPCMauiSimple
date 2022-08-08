using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigooPCMauiSimple.Models
{
  internal class DataModels
  {
  }
  public class AboutUs
  {

    [Key]
    public int Id { get; set; }

    [MaxLength(30), Display(Name = "Header Title")]
    public string HeadTitle { get; set; }

    [MinLength(40)]
    public string Content { get; set; }



  }

  public class ApplicationUser : IdentityUser
  {
    [Display(Name = "Last Name")]
    public string LastName { get; set; }



    [Display(Name = "Middle Name")]
    public string MiddleName { get; set; }



    [Display(Name = "First Name")]
    public string FirstName { get; set; }



    [Display(Name = "About Agent"), MinLength(15)]
    public string About { get; set; }


    public string Address { get; set; }


    public string Skills { get; set; }

    public string Quote { get; set; }


    [Display(Name = "Phone Number")]
    public string MobileNumber { get; set; }



    public string Skype { get; set; }



    [Display(Name = "Language spoken")]
    public string Language { get; set; }



    [Url, Display(Name = "Facebook Link")]
    public string FacebookLink { get; set; }



    [Url, Display(Name = "Twitter Link")]
    public string TwitterLink { get; set; }



    [Url, Display(Name = "Instagram Link")]
    public string InstagramLink { get; set; }



    [Url, Display(Name = "LinkedIn Link")]
    public string LinkedInLink { get; set; }

    [Display(Name = "Image Name")]
    public string ImageName { get; set; }

    [NotMapped, Display(Name = "Upload File")]
    public IFormFile UploadedFile { get; set; }

  }


  public class HomePageSliders
  {
    public int Id { get; set; }

    public string ImageName { get; set; }




  }

  public class ContactUs
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    public string message { get; set; }

    [Required, Display(Name = "Is Viewed")]
    public bool isViewed { get; set; }
  }

  public class Currency
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Sign { get; set; }
  }

  public class Messages
  {
    [Key]
    public int Id { get; set; }

    public string Content { get; set; }

    public string Subject { get; set; }

    [Display(Name = "Attachment Name")]
    public string AttachmentName { get; set; }

    [Display(Name = "Date Sent")]
    public DateTime DateSent { get; set; }

    [Display(Name = "Is Important")]
    public bool IsImportant { get; set; }

    //Relationship

    public ApplicationUser Sender { get; set; }

    [Display(Name = "Sender")]
    public string SenderId { get; set; }

    public ApplicationUser Reciever { get; set; }

    [Display(Name = "Reciever")]
    public string RecieverId { get; set; }
  }

  public class NavigationHeaders
  {

    public int Id { get; set; }


    public string Name { get; set; }
  }

  public class News
  {
    [Key]
    public int Id { get; set; }

    [Display(Name = "Image Title")]
    public string ImageTitle { get; set; }

    [Display(Name = "Date Posted")]
    public DateTime DatePosted { get; set; }

    [Required]
    public string Title { get; set; }
    [Required]
    public string Content { get; set; }


    //Relationship

    public NewsCategory NewsCategory { get; set; }

    [Display(Name = "News Categotry")]
    public int NewsCategoryId { get; set; }


    public ApplicationUser Author { get; set; }

    [Display(Name = "Author")]
    public string AuthorId { get; set; }


    [NotMapped, Display(Name = "Upload File")]
    public IFormFile UploadedFile { get; set; }
  }

  public class NewsCategory
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
  }


  public class NewsComment
  {
    [Key]
    public int Id { get; set; }


    public string Comment { get; set; }

    public DateTime DatePosted { get; set; }


    public ApplicationUser Commenter { get; set; }

    [Display(Name = "Commenter")]
    public string CommenterId { get; set; }

    public News News { get; set; }

    [Display(Name = "News")]
    public int NewsId { get; set; }


  }

  public class OurService
  {
    [Key]
    public int Id { get; set; }


    [Required]
    public string Name { get; set; }

    [Required, Display(Name = "Icon Image Name")]
    public string IconImage { get; set; }

    [Required, MinLength(20)]
    public string Content { get; set; }
  }

  public class Property
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Address { get; set; }

    [Display(Name = "Google Map Address")]
    public string GoogleMapAddress { get; set; }

    [Display(Name = "Main Image Name")]
    public string MainImageName { get; set; }

    [Required]
    public double Price { get; set; }
    [Required]
    public string Description { get; set; }
    [Required, Display(Name = "Area in M²")]
    public double Area { get; set; }
    [Display(Name = "Number of Bed-Rooms")]
    public int BedRooms { get; set; }

    [Display(Name = "Number of Number of Bath-Rooms")]
    public int bathrooms { get; set; }

    [Display(Name = "Number of Number of Garage")]
    public int Garage { get; set; }

    [Display(Name = "Floor Plan Image Link")]
    public string FloorPlanImage { get; set; }

    [Display(Name = "Property has been sold or rented")]
    public bool isDealClosed { get; set; }
    [Display(Name = "Show in homepage")]
    public bool isDisplayed { get; set; }

    [NotMapped, Display(Name = "Upload File")]
    public IFormFile UploadedFile { get; set; }






    //Relationship

    public Currency Currency { get; set; }

    [Display(Name = "Currency")]
    public int CurrencyId { get; set; }



    public PropertyType PropertyType { get; set; }

    [Display(Name = "Property Type")]
    public int PropertyTypeId { get; set; }


    public PropertyMode PropertyMode { get; set; }

    [Display(Name = "Property Mode")]
    public int PropertyModeId { get; set; }



    public ApplicationUser User { get; set; }

    [Display(Name = "Agent")]
    public string UserId { get; set; }

    [Display(Name = "Video Link")]
    public string VideoLink { get; set; }


    public ApplicationUser ClosedTo { get; set; }

    [Display(Name = "Closed To")]
    public string ClosedToId { get; set; }


  }


  public class PropertyAmenities
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }


    //Relationships

    public Property Property { get; set; }

    [Display(Name = "Property")]
    public int PropertyId { get; set; }
  }

  public class PropertyMode
  {
    [Key]
    public int Id { get; set; }


    [Required]
    public string Name { get; set; }
  }

  public class PropertySlider
  {
    [Key]
    public int Id { get; set; }

    [Display(Name = "Image")]
    public string ImageName { get; set; }

    [NotMapped, Display(Name = "Upload File")]
    public IFormFile UploadedFile { get; set; }

    //Relationship
    public Property Properties { get; set; }

    [Display(Name = "Property")]
    public int PropertiesId { get; set; }
  }

  public class PropertyType
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
  }

  public class SocialMedia
  {
    [Key]
    public int Id { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Address { get; set; }

    [Required, Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    [Required, Display(Name = "Google Link")]
    public string GoogleAddress { get; set; }


    [Url, Display(Name = "Facebook Link")]
    public string FacebookLink { get; set; }



    [Url, Display(Name = "Twitter Link")]
    public string TwitterLink { get; set; }



    [Url, Display(Name = "Instagram Link")]
    public string InstagramLink { get; set; }



    [Url, Display(Name = "LinkedIn Link")]
    public string LinkedInLink { get; set; }


  }

  public class Testimonials
  {
    [Key]
    public int Id { get; set; }

    [Required, MinLength(10)]
    public string Testimony { get; set; }

    public string ImageName { get; set; }

    [NotMapped, Display(Name = "Upload File")]
    public IFormFile UploadedFile { get; set; }


    //Relationship

    public ApplicationUser User { get; set; }


    [Required, Display(Name = "User")]
    public string UserId { get; set; }

    [Required]
    public bool isApproved { get; set; }


  }

}
