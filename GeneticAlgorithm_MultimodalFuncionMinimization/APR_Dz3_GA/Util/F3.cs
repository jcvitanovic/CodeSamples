using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_Dz3_GA
{
    public class F3 : IFunction
    {
        #region Fields

        private List<double> _parameters = new List<double>();

        #endregion

        #region Properties

        public List<double> Parameters
        {
            get
            {
                return _parameters;
            }

        }

        #endregion

        #region Methods

        public double Calculate(Vector vector)
        {
            double result = 0;

            for (int i = 0; i < vector.Dimension; i++)
            {
                result += Math.Pow((vector.Components[i] - Parameters[i]), 2);
            }
            return result;
        }

        #endregion
    }
}
