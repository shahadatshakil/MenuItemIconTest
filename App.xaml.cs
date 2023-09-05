namespace MAUITestProject_MenuItem_;

public partial class App : Application
{
    private static Window _window;

    public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        _window = base.CreateWindow(activationState);

        return _window;
    }
}
