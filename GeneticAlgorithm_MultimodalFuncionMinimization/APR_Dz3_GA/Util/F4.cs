using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_Dz3_GA
{
    public class F4 : IFunction
    {
        #region Methods

        public double Calculate(Vector vector)
        {
            double result = 0;

            result = (vector.Components[0] - vector.Components[1]) * (vector.Components[0] + vector.Components[1]);
            result = Math.Abs(result);
            result += Math.Pow(((vector.Components[0] * vector.Components[0]) + (vector.Components[1] * vector.Components[1])), 0.5);
            
            return result;
        }

        #endregion
    }
}
