using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpGPX
{
	public class GPX_TrackSegment
	{
		private List<GPX_TrackPoint> _segmentPoints;

		public GPX_TrackSegment(GPX_TrackPoint singlePoint)
		{
			this._segmentPoints = new List<GPX_TrackPoint>();
			this._segmentPoints.Add(singlePoint);
		}

		public GPX_TrackSegment(List<GPX_TrackPoint> pointsList)
		{
			this._segmentPoints = pointsList;
		}

		public void AddTrackPoint(GPX_TrackPoint singlePoint)
		{
			this._segmentPoints.Add(singlePoint);
		}

		public string ToXMLstring()
		{
			StringBuilder track_segment_builder = new StringBuilder("\r\n\t<trkseg>");
			foreach (GPX_TrackPoint point in this._segmentPoints)
			{
				track_segment_builder.AppendLine(point.ToXMLstring());
			}
			track_segment_builder.AppendLine("\t</trkseg>");
			return track_segment_builder.ToString();
		}

	}
}
