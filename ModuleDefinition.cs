using MAUITestProject_MenuItem_.ViewModels;

namespace MAUITestProject_MenuItem_;

public class ModuleDefinition : IModule

{
    public void OnInitialized(IContainerProvider containerProvider)
    {

    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterSingleton<IEventAggregator, EventAggregator>();

        containerRegistry.RegisterSingleton<MainPage>();
        containerRegistry.RegisterSingleton<MainPageViewModel>();
        containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
    }
}
