using System;
namespace cSharpGPX
{
	public class GPX_TrackPoint
	{
		private GPX_PositionStruct _pointPosition;

		private string _latitude;
		private string _longitude;
		private decimal _elevation;
		private DateTime _time;

		public GPX_TrackPoint(string latitude, string longitude, decimal elevation, DateTime time)
		{
			this._latitude = latitude;
			this._longitude = longitude;
			this._elevation = elevation;
			this._time = time;
		}

		public string ToXMLstring()
		{
			return String.Format("\r\n\t<trkpt lat=\"{0}\" lon=\"{1}\" >" +
								 "\t<ele>{2}</ele>" +
								 "\t<time>{3}</time>" +
			                     "\r\n\t</trkpt>", this._latitude, this._longitude
								 , this._elevation, this._time);
		}

		public string Latitude
		{
			get { return this._latitude; }
		}

		public string Longitude
		{
			get { return this._longitude; }
		}

		public decimal Elevation
		{
			get { return this._elevation; }
		}

		public DateTime Time
		{
			get { return this._time; }
		}

	}
}
