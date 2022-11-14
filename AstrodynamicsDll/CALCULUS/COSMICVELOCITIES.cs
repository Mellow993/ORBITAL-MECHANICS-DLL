using AstrodynamicsDll.Constants;

namespace AstrodynamicsDll.CALCULUS
{
    /// <summary>
    /// Calculate the first, second and third cosmic velocities.
    /// </summary>
    /// <remarks>
    /// In this class, the first, second and third 
    /// cosmic velocities can be calculated.
    /// </remarks>

    public static class COSMICVELOCITIES
    {
        #region METHODS COSMICVELOCITIES
        public static double G_FCV(double M, double r)
        => Math.Sqrt(AC.GC * M / r);

        public static double G_SCV(double M, double r)
            => Math.Sqrt(2 * AC.GC * M / r);

        public static double G_TCV(double r)
            => Math.Sqrt(2 * AC.GC * (COP.M_SUN / r) );
        #endregion
    }
}