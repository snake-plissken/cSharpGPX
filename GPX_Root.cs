using System;

namespace cSharpGPX
{
	public class GPX_Root
	{
		private GPX_Track _track;
		private string _root_name;

		public GPX_Root(GPX_Track track)
		{
			this._track = track;
		}

		public GPX_Track Track
		{
			get { return this._track; }
		}

		public string ReturnXMLOutput()
		{
			string track_data = this.Track.ToXMLstring();
			string gpx = "<gpx version=\"1.0\">{0}</gpx>";
			return String.Format(gpx, track_data);
		}
	}
}
