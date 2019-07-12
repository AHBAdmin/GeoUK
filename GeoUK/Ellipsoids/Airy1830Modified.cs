using System;

namespace GeoUK.Ellipsoids
{

    /// <summary>
	/// This immutable class, derived from Ellipsoid, represents an Airy1930 ellipsoid and is provided for convienience.
    /// </summary>
    public class Airy1830Modified : Ellipsoid
	{
		private const double  C_SEMI_MAJOR_AXIS          = 6377340.189;             //a
		private const double  C_SEMI_MINOR_AXIS          = 6356034.447;             //b


        /// <summary>
        /// Constructor.
        /// </summary>
		public Airy1830Modified()
            : base(C_SEMI_MAJOR_AXIS, C_SEMI_MINOR_AXIS)
        {
        }

	}
}
