using System;
namespace cSharpGPX
{
	public class GPX_Waypoint
	{
		private GPX_PositionStruct _waypointPosition;
		private decimal _elevation;
		private string _name;

		public GPX_Waypoint(GPX_PositionStruct poition, decimal elevation, string name)
		{
			this._waypointPosition = poition;
			this._elevation = elevation;
			this._name = name;
		}

		public string ToXMLstring()
		{
			return "<wpt " + this._waypointPosition.ToXMLstring() + ">"
								 + "<ele> " + this._elevation.ToString()
								 + "</ele> <name> " + this._name
								 + "</name>"
								 + "</wpt>";
		}

	}
}
