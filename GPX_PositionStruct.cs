using System;
namespace cSharpGPX
{
	public struct GPX_PositionStruct
	{
		private string _latitude;
		private string _longitude;

		public GPX_PositionStruct(double latitude, double longitude)
		{
			this._latitude = latitude.ToString();
			this._longitude = longitude.ToString();
		}

		public string ToXMLstring()
		{
			return String.Format("lat=\"{0}\" lon=\"{1}\"", this._latitude, this._longitude);
		}

		public string Latitude
		{
			get { return this._latitude;}
		}

		public string Longitude
		{
			get { return this._longitude; }
		}
	
	}
}
