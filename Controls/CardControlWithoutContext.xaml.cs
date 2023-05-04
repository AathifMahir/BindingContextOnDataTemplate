namespace BindingContextOnDataTemplate.Controls;

public partial class CardControlWithoutContext : ContentView
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(CardControlWithBindingContext), default);
    public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(ImageSource), typeof(CardControlWithBindingContext), default);
    public static readonly BindableProperty CardBackgroundProperty = BindableProperty.Create(nameof(CardBackground), typeof(Color), typeof(CardControlWithBindingContext), Colors.Black);

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public ImageSource Image
    {
        get => (ImageSource)GetValue(ImageProperty);
        set => SetValue(ImageProperty, value);
    }

    public Color CardBackground
    {
        get => (Color)GetValue(CardBackgroundProperty);
        set => SetValue(CardBackgroundProperty, value);
    }
    public CardControlWithoutContext()
	{
		InitializeComponent();
	}
}