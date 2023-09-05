
using Prism.Modularity;

namespace MAUITestProject_MenuItem_;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UsePrism(prism =>
            {
                prism.RegisterTypes(containerRegistry =>
                {
                    containerRegistry.RegisterForNavigation<MainPage>();
                });

                prism.ConfigureModuleCatalog(moduleCatalog =>
                {
                    moduleCatalog.AddModule<ModuleDefinition>();
                });

                prism.OnAppStart("NavigationPage/MainPage");
            })
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Font-Icons.ttf", "IconsFont");
			});

		return builder.Build();
	}
}
