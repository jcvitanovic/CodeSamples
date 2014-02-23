using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_Dz3_GA
{
    public class Vector
    {
        #region Properties

        public int Dimension
        {
            get;
            set;
        }

        public List<double> Components
        {
            get;
            set;
        }

        #endregion

        #region Constructors

        public Vector()
        {
            Components = new List<double>();
        }

        #endregion


    }
}
