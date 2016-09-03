using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Acr.UserDialogs;
using System.Threading.Tasks;

namespace auladesabado
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e) 
		{
			//DisplayAlert(txtLogin.Text, txtSenha.Text, "Ok", "Cancel");

			UserDialogs.Instance.ShowLoading("Logando como " + txtLogin.Text);

			await Task.Delay(3000);

			UserDialogs.Instance.HideLoading();

			Navigation.InsertPageBefore(new TabbedMainPage(), this);
			await Navigation.PopAsync();
		}

		async void Cadastrar_Clicked(object sender, System.EventArgs e)
		{
			Navigation.InsertPageBefore(new CadastrarPage(), this);
			await Navigation.PopAsync();
		}
	}
}

