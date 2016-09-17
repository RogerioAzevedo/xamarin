using System;
using System.Collections.Generic;
using Plugin.Geolocator;
using Newtonsoft.Json;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace auladesabado
{
	public partial class DadosPage : ContentPage
	{
		public DadosPage()
		{
			InitializeComponent();

			geoloc();
		}

		async void geoloc()
		{
			var locator = CrossGeolocator.Current;
			locator.DesiredAccuracy = 50;

			var position = await locator.GetPositionAsync(10000);

			string testeLat = position.Latitude.ToString();
			string testeLon = position.Longitude.ToString();

			var myPosition =  MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude), Distance.FromMiles(1));

			var pin = new Pin
			{
				Type = PinType.Place,
				Position = new Position(position.Latitude, position.Longitude),
				Address = "Terra do Nunca",
				Label = "Teste" 
			};

			map.Pins.Add(pin);
			map.MoveToRegion(myPosition);

			string sUrl = "http://api.geonames.org/findNearByWeatherJSON?lat=" + testeLat + "&lng=" + testeLon + "&username=deznetfiap";

			using (HttpClient client = new HttpClient())
			{
				var uri = new Uri(sUrl);

				var response = await client.GetAsync(uri);

				TempoResultModel tempo = new TempoResultModel();

				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();

					tempo = JsonConvert.DeserializeObject<TempoResultModel>(content);

					lblLat.Text = tempo.weather.lat.ToString();
					lblLong.Text = tempo.weather.lng.ToString();


				}
				else
				{
					/*UserDialogs.Instance.ShowSuccess("Falha na requisicao!");*/
				}
			}
		}
	}
}

