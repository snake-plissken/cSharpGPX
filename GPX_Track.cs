using System;
namespace cSharpGPX
{
	public class GPX_Track
	{
		private GPX_TrackSegment _trackSegment;
		private string _name;
		private int _number;

		public GPX_Track(GPX_TrackSegment trackSegment, string name = "", int number = 0)
		{
			this._trackSegment = trackSegment;
			this._name = name;
			this._number = number;
		}

		public string ToXMLstring()
		{
			return "\r\n\t<trk>" + this._trackSegment.ToXMLstring() + "\r\n\t</trk>";
		}

		public GPX_TrackSegment TrackSegment
		{
			get { return this._trackSegment; }
		}

		public string TrackName
		{
			get { return this._name; }
		}

		public int TrackNumber
		{
			get { return this._number; }
		}


	}
}
