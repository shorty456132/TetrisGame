namespace TetrisGame;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//set applicatoin's entry point and create a new instance of main page
		MainPage = new NavigationPage(new MainPage());
	}
}
