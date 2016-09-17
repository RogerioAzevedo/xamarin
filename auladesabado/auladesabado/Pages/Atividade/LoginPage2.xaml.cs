using System;
using System.Collections.Generic;
using Acr.UserDialogs;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace auladesabado
{
	public partial class LoginPage2 : ContentPage
	{
		public LoginPage2()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushModalAsync(new NavigationPage(new RecuperarSenhaPage2()));
		}

		async void Recuperar_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new NavigationPage(new TabbedMainPage2()));
		}
	}
}

