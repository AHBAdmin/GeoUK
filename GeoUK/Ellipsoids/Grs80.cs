using System;

namespace GeoUK.Ellipsoids
{
    /// <summary>
	/// This immutable class, derived from Ellipsoid, represents an GRS80 ellipsoid and is provided for convienience.
    /// </summary>
    public class Grs80 : Ellipsoid
    {
        //WGS constants
        private const double C_SEMI_MAJOR_AXIS = 6378137;             //a
        private const double C_SEMI_MINOR_AXIS = 6356752.314;         //b

        /// <summary>
        /// Consructor.
        /// </summary>
        public Grs80()
            : base(C_SEMI_MAJOR_AXIS, C_SEMI_MINOR_AXIS)
        {
        }

    }
}

