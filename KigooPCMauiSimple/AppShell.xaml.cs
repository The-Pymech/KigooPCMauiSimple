using KigooPCMauiSimple.Views;

namespace KigooPCMauiSimple;

public partial class AppShell : Shell
{
  public AppShell()
  {
    InitializeComponent();


    Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
  }
}
