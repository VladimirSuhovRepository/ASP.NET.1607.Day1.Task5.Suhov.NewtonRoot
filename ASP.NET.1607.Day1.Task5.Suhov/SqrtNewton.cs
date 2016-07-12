using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day1.Task5.Suhov
{
    public static class SqrtNewton
    {
        /// <summary>Finding of root</summary>
        /// <param name="value">Value for which you want to search the root</param>
        /// <param name="degree">Degree of root</param>
        /// <param name="precision">Precision of root</param>
        /// <returns>Root of <paramref name="degree"/>-degree for the <paramref name="value"/></returns>
        public static double GetSqrt(double value, double degree, double precision)
        {
            if (value.Equals(double.NaN)) return double.NaN;
            if (precision < 1E-16 || precision > 1) throw new ArgumentOutOfRangeException(nameof(precision));
            if(value<0) return double.NaN;
            if (value == 0) return 0;
            if (Math.Abs(value) < precision)  return 0;
            if (value < 0 && degree % 2 == 0) return double.NaN;
            double n = degree;
            double x = 1;
            double prec = precision;
            while (1 == 1)
            {
                double formula = 1 / n * ((n - 1) * x + (value / Math.Pow(x, n - 1)));
                if (Math.Abs(x - formula) < prec) return x;
                x = formula;
            }
        }
    }
}
