using PP2AndresNunez.MVVM.Views;

namespace PP2AndresNunez;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ANRecargasMain();
	}
}
