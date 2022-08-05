using KigooPCMauiSimple.ViewModels.AppViewModel;

namespace KigooPCMauiSimple.Views;

public partial class DetailsPage : ContentPage
{
  public DetailsPage(PropertyDetailsViewModel vm)
  {
    InitializeComponent();
    BindingContext = vm;
  }


  protected override void OnNavigatedTo(NavigatedToEventArgs args)
  {
    base.OnNavigatedTo(args);
  }

  private async void Button_Clicked(object sender, EventArgs e)
  {
    var vm = this.BindingContext as PropertyDetailsViewModel;
    var agent = vm.PropertyDetailViewModel.Agent;

    var response = await Shell.Current.DisplayAlert($"Contact {agent.LastName}", $"How do you want to contact {agent.LastName}?", "Call", "Email");
    if (response == true)
    {
      try
      {
        await CallAgent(agent.PhoneNumber.ToString());
      }
      catch
      {

        await Shell.Current.DisplayAlert($"Oops", $"Agent {agent.LastName} has not set Phone Number", "Ok");
      }

    }
    else if (response == false)
    {

      try
      {
        await MailAgent(agent.Email);
      }
      catch
      {


      }

    }

  }


  async Task CallAgent(string phoneNumber)
  {
    if (PhoneDialer.Default.IsSupported)
      PhoneDialer.Default.Open(phoneNumber);
  }


  async Task MailAgent(string AgentEmail)
  {
    if (Email.Default.IsComposeSupported)
    {

      string subject = "Property Application";
      string body = "<Enter your message>";
      string[] recipients = new[] { AgentEmail };

      var message = new EmailMessage
      {
        Subject = subject,
        Body = body,
        BodyFormat = EmailBodyFormat.PlainText,
        To = new List<string>(recipients)
      };



      await Email.Default.ComposeAsync(message);
    }
  }
}