using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Acr.UserDialogs;
using Plugin.Geolocator;

namespace auladesabado
{
	public partial class EnderecoPage : ContentPage
	{
		public EnderecoPage()
		{
			InitializeComponent();

			geoloc();
		}

		async void geoloc() 
		{
			/*var locator = CrossGeolocator.Current;
			locator.DesiredAccuracy = 50;

			var position = await locator.GetPositionAsync(10000);

			string testeLat = position.Latitude.ToString();
			string testeLon = position.Longitude.ToString();*/
		}

		async void Handle_Focused(object sender, Xamarin.Forms.FocusEventArgs e)
		{
			string sUrl = "http://viacep.com.br/ws/{0}/json/";

			using (HttpClient client = new HttpClient()) 
			{ 
				var uri = new Uri(string.Format(sUrl, txtCEP.Text));

				var response = await client.GetAsync(uri);

				CepResultModel cep = new CepResultModel();

				if (response.IsSuccessStatusCode)
				{
					UserDialogs.Instance.ShowSuccess("Resquisicao ok");

					var content = await response.Content.ReadAsStringAsync();

					cep = JsonConvert.DeserializeObject<CepResultModel>(content);

					txtEndereco.Text = cep.logradouro;
					txtBairro.Text = cep.bairro;
					txtCidade.Text = cep.localidade;
					txtEstado.Text = cep.uf;
					txtNumero.Focus();
				}
				else
				{
					UserDialogs.Instance.ShowSuccess("Falha na requisicao!");
				}
			}


		}
	}
}

