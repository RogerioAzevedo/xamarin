using Xamarin.Forms;

namespace auladesabado
{
	public partial class App : Application
	{
		private static NavigationPage _navigationPage;
		public static NavigationPage NavigationPage 
		{ 
			get { return _navigationPage;}
			set { _navigationPage = value;}
		}

		public App()
		{
			InitializeComponent();

			//MainPage = new TabbedMainPage();

			MainPage = new NavigationPage(new LoginPage2());

		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

