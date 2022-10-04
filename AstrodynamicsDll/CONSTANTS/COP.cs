namespace AstrodynamicsDll.Constants
{
    public static class AC // Astrodynamicreadonlyants
    {
        public static double MER_Eng = Math.Pow(2092567257, 7);                         // ft
        public static readonly double MER_Met = 6378145;                                // m
        public static readonly double GC = Math.Pow(6.67, -11);                         // m^3 / kg*s^2 (Gravity readonlyant)
    }

    public static class COP // CONSTANTS OF PLANETS
    {
        #region MASS OF SUN PLANETS AND EARTH'S MOON 
        public static readonly double M_SUN = Math.Pow(1.9891, 1030);                    // kg;
        public static readonly double M_MERCURY = Math.Pow(3.301, 23);                   // kg;
        public static readonly double M_VENUS = Math.Pow(4.867, 24);                     // kg;
        public static readonly double M_EARTH = Math.Pow(5.972, 24);                     // kg;
        public static readonly double M_EARTH_MOON = Math.Pow(7.348, 22);                // kg;
        public static readonly double M_MARS = Math.Pow(6.417, 23);                      // kg;
        public static readonly double M_JUPITER = Math.Pow(1.899, 27);                   // kg;
        public static readonly double M_SATURN = Math.Pow(5.685, 26);                    // kg;
        public static readonly double M_URANUS = Math.Pow(8.682, 25);                    // kg;
        public static readonly double M_NEPTUN = Math.Pow(1.024, 26);                    // kg;
        public static readonly double M_PLUTO = Math.Pow(1.471, 22);                     // kg;
        #endregion

        #region RADIUS OF SUN PLANETS AND EARTH'S MOON 
        public static readonly double R_SUN = 696340 * 1000;                             // m;
        public static readonly double R_MERCURY = 2439.7 * 1000;                         // m;
        public static readonly double R_VENUS = 6051.8 * 1000;                           // m;
        public static readonly double R_EARTH = 6371 * 1000;                             // m;
        public static readonly double R_EARTH_MOON = 7.348 * 1000;                       // m;
        public static readonly double R_MARS = 3389.5 * 1000;                            // m;
        public static readonly double R_JUPITER = 69911 * 1000;                          // m;
        public static readonly double R_SATURN = 58232 * 1000;                           // m;
        public static readonly double R_URANUS = 25362 * 1000;                           // m;
        public static readonly double R_NEPTUN = 24622 * 1000;                           // m;
        public static readonly double R_PLUTU = 1188.3 * 1000;                           // m;
        #endregion

        #region VOLUME OF SUN PLANETS AND EARTH'S MOON 
        public static readonly double V_SUN = GV(696340 * 1000);                         // m^3;
        public static readonly double V_MERCURY = GV(2439.7 * 1000);                     // m^3;
        public static readonly double V_VENUS = GV(6051.8 * 1000);                       // m^3;
        public static readonly double V_EARTH = GV(6371 * 1000);                         // m^3;
        public static readonly double V_EARTH_MOON = GV(7.348 * 1000);                   // m^3;
        public static readonly double V_MARS = GV(3389.5 * 1000);                        // m^3;
        public static readonly double V_JUPITER = GV(69911 * 1000);                      // m^3;
        public static readonly double V_SATURN = GV(58232 * 1000);                       // m^3;
        public static readonly double V_URANUS = GV(25362 * 1000);                       // m^3;
        public static readonly double V_NEPTUN = GV(24622 * 1000);                       // m^3;
        public static readonly double V_PLUTO = GV(1188.3) * 1000;                       // m^3;
        #endregion

        #region DENSITY OF SUN PLANETS AND EARTH'S MOON 
        public static readonly double D_SUN = GD(M_SUN, V_SUN);                         // kg/m^3
        public static readonly double D_MERCURY = GD(M_MERCURY, V_MERCURY);             // kg/m^3
        public static readonly double D_VENUS = GD(M_VENUS, V_VENUS);                   // kg/m^3
        public static readonly double D_EARTH = GD(M_EARTH, V_EARTH);                   // kg/m^3
        public static readonly double D_EARTH_MOON = GD(M_EARTH_MOON, V_EARTH_MOON);    // kg/m^3
        public static readonly double D_MARS = GD(M_MARS, V_MARS);                      // kg/m^3
        public static readonly double D_JUPITER = GD(M_JUPITER, V_JUPITER);             // kg/m^3
        public static readonly double D_SATURN = GD(M_SATURN, V_SATURN);                // kg/m^3
        public static readonly double D_URANUS = GD(M_URANUS, V_URANUS);                // kg/m^3
        public static readonly double D_NEPTUN = GD(M_NEPTUN, V_NEPTUN);                // kg/m^3
        public static readonly double D_PLUTU = GD(M_PLUTO, V_PLUTO);                   // kg/m^3
        #endregion

        #region METHODS
        private static double GV(double radius)
            => 4 / 3 * Math.Pow(radius, 3) * Math.PI;
        private static double GD(double mass, double volume)
            => volume / mass;
        #endregion
    }

}
