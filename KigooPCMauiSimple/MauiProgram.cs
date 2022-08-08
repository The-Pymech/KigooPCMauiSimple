using KigooPCMauiSimple.Services;
using KigooPCMauiSimple.ViewModels.AppViewModel;
using KigooPCMauiSimple.Views;

namespace KigooPCMauiSimple;

public static class MauiProgram
{
  public static MauiApp CreateMauiApp()
  {
    var builder = MauiApp.CreateBuilder();
    builder
         .UseMauiApp<App>()
         .ConfigureFonts(fonts =>
         {
           fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
           fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
         });


    builder.Services.AddSingleton<HomeService>();
    builder.Services.AddSingleton<PropertiesService>();
    builder.Services.AddTransient<RestService>();



    builder.Services.AddSingleton<HomePage>();
    builder.Services.AddSingleton<PropertyPage>();
    builder.Services.AddTransient<DetailsPage>();


    builder.Services.AddSingleton<BasePageViewModel>();
    builder.Services.AddSingleton<HomeViewModel>();
    builder.Services.AddSingleton<PropertiesViewModel>();
    builder.Services.AddTransient<PropertyDetailsViewModel>();

    return builder.Build();
  }
}
