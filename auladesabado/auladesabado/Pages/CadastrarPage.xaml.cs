using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace auladesabado
{
	public partial class CadastrarPage : ContentPage
	{
		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopModalAsync(true);
		}

		public CadastrarPage()
		{
			InitializeComponent();
		}
	}
}

