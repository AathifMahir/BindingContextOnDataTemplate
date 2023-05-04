using BindingContextOnDataTemplate.Models;

namespace BindingContextOnDataTemplate;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = this;
	}

	public List<ControlModel> ControlItems { get; set; } = new List<ControlModel>() { 
		new ControlModel()
		{
			Title = "WinUI",
			BackgroundColor = Colors.LightBlue,
		},
        new ControlModel()
        {
            Title = "Maui",
            BackgroundColor = Colors.Purple,
        },
        new ControlModel()
        {
            Title = "WPF",
            BackgroundColor = Colors.Blue,
        },
        new ControlModel()
        {
            Title = "Blazor",
            BackgroundColor = Colors.MediumPurple,
        },
        new ControlModel()
        {
            Title = "UWP",
            BackgroundColor = Colors.Cyan,
        },
    };

}

