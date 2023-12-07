using PrismApp.Controls;
using PrismApp.ViewModels;
using PrismApp.Views;

namespace PrismApp;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
                .OnAppStart("NavigationPage/MainPage");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForRegionNavigation<CustomControl, CustomControlViewModel>();
        containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>()
                     .RegisterInstance(SemanticScreenReader.Default);
    }
}
