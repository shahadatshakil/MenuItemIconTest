namespace MAUITestProject_MenuItem_.ViewModels;

public class MainPageViewModel : BindableBase
{
    private string icon1;
    private string icon2;

    private string testString;

    private FontImageSource iconImage1;
    private FontImageSource iconImage2;


    public FontImageSource IconImage1
    {
        get { return iconImage1; }
        set { 
            iconImage1 = value;
            RaisePropertyChanged(nameof(IconImage1));
        }
    }

    public FontImageSource IconImage2
    {
        get { return iconImage2; }
        set
        {
            iconImage2 = value;
            RaisePropertyChanged(nameof(IconImage2));
        }
    }

    public string Icon1
    {
        get { return icon1; }
        set 
        { 
            icon1 = value;
            RaisePropertyChanged(nameof(Icon1));
        }
    }

    public string Icon2
    {
        get { return icon2; }
        set
        {
            icon2 = value;
            RaisePropertyChanged(nameof(Icon2));
        }
    }

    public string TestString
    {
        get { return testString; }
        set
        {
            testString = value;
            RaisePropertyChanged(nameof(TestString));
        }
    }

    public MainPageViewModel()
    {
        Icon1 = "\ue913";
        Icon2 = "\ue91e";

        IconImage1 = new FontImageSource
        {
            FontFamily = "IconsFont",
            Glyph = Icon1,
            Color = Colors.Blue
        };

        IconImage2 = new FontImageSource
        {
            FontFamily = "IconsFont",
            Glyph = Icon2,
            Color = Colors.Green
        };

        TestString = "Open File";
    }

    public void SwapIcon()
    {
        Icon1 = "\ue91e";
        Icon2 = "\ue913";

        //these does not update the UI
        IconImage1.Color = Colors.Yellow;
        IconImage1.Glyph = "\ue91e";
        IconImage2.Glyph = "\ue913";

        TestString = "File opened! Congrats!";
    }
}
