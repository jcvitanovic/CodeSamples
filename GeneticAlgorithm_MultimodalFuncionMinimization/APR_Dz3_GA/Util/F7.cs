using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_Dz3_GA
{

    public class F7 :IFunction
    {
        #region Methods

        public double Calculate(Vector vector)
        {
            double result = 0;
            double sumComponentsSquare = 0;

            foreach (double component in vector.Components)
            {
                sumComponentsSquare += (Math.Pow(component, 2));
            }

            result = Math.Pow(sumComponentsSquare, 0.1);
            result *= 50;
            result = Math.Sin(result);
            result = Math.Pow(result, 2);
            result += 1;

            result *= (Math.Pow(sumComponentsSquare, 0.25));


            return result;
        }

        #endregion
    }
}
