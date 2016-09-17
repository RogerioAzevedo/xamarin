using System;
using System.Collections.Generic;
using Acr.UserDialogs;
using System.Threading.Tasks;


using Xamarin.Forms;

namespace auladesabado
{
	public partial class RecuperarSenhaPage2 : ContentPage
	{
		public RecuperarSenhaPage2()
		{
			InitializeComponent();
		}

		void enviar_Handle_Clicked(object sender, System.EventArgs e)
		{
			UserDialogs.Instance.ShowSuccess("Enviando..." + txtEmail.Text, 2000);	
		}

		async void cancelar_Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopModalAsync();
		}
	}
}

