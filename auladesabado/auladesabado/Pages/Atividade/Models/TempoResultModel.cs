﻿using System;
namespace auladesabado
{
	public class WeatherObservation
	{
		public int elevation { get; set; }
		public double lng { get; set; }
		public string observation { get; set; }
		public string ICAO { get; set; }
		public string clouds { get; set; }
		public string dewPoint { get; set; }
		public string cloudsCode { get; set; }
		public string datetime { get; set; }
		public string countryCode { get; set; }
		public string temperature { get; set; }
		public int humidity { get; set; }
		public string stationName { get; set; }
		public string weatherCondition { get; set; }
		public int windDirection { get; set; }
		public string windSpeed { get; set; }
		public double lat { get; set; }
	}

	public class TempoResultModel
	{
		public WeatherObservation weather;
		
		public TempoResultModel()
		{
			weather = new WeatherObservation();
		}
	}
}

