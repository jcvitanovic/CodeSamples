using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_Dz3_GA
{
    public class F6 : IFunction
    {
        #region Methods

        public double Calculate(Vector vector)
        {
            double result = 0;
            double sumComponentsSquare = 0;
            double numerator, denumerator;

            foreach(double component in vector.Components)
            {
                sumComponentsSquare += (Math.Pow(component,2));
            }

            numerator = Math.Pow(sumComponentsSquare, 0.5);
            numerator = Math.Sin(numerator);
            numerator = Math.Pow(numerator,2);
            numerator -= 0.5;

            denumerator = 0.001 * sumComponentsSquare;
            denumerator += 1;
            denumerator = Math.Pow(denumerator, 2);


            result = 0.5 + (numerator / denumerator);

            return result;

        }

        #endregion
    }
}
