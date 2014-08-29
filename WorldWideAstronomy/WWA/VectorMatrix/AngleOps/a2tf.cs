using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWideAstronomy
{
    public static partial class WWA
    {
        /// <summary>
        /// Decompose radians into hours, minutes, seconds, fraction.
        /// </summary>
        /// 
        /// <remarks>
        /// This function is derived from the International Astronomical Union's
        /// SOFA (Standards of Fundamental Astronomy) software collection.
        /// http://www.iausofa.org
        /// The code does not itself constitute software provided by and/or endorsed by SOFA.
        /// This version is intended to retain identical functionality to the SOFA library, but
        /// made distinct through different function names (prefixes) and C# language specific
        /// modifications in code.
        /// </remarks>
        /// /// Given:
        /// <param name="ndp">resolution (Note 1)</param>
        /// <param name="angle">angle in radians</param>
        /// Returned:
        /// <param name="sign">'+' or '-'</param>
        /// <param name="ihmsf">hours, minutes, seconds, fraction</param>
        public static void wwaA2tf(int ndp, double angle, ref char sign, int[] ihmsf)
        {
            /* Scale then use days to h,m,s function. */
            wwaD2tf(ndp, angle / D2PI, ref sign, ihmsf);

            return;
        }
    }
}