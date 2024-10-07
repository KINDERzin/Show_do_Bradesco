namespace ShowDoBradesco;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	public void BotaoComecar(object s, EventArgs e)
	{
		Application.Current.MainPage = new GamePage();
	}
}

