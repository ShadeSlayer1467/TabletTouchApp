using TabletTouchApp.ViewModels;

namespace TabletTouchApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        BindingContext = new USBViewModel();
    }
}

