using PrismApp.Controls;
using PrismApp.ViewModels;
using PrismApp.Views;

namespace PrismApp;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        ViewModelLocationProvider.Register<CustomControl, CustomControlViewModel>();
        ViewModelLocationProvider2.Register<CustomControl, CustomControlViewModel>();
        builder.RegisterTypes(RegisterTypes)
                .OnAppStart("NavigationPage/MainPage");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage>()
                     .RegisterInstance(SemanticScreenReader.Default);
    }
}
