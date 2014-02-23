using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_Dz3_GA
{
    public class Chromosome
    {
        #region Fields

        double _realValue;
        List<string> _binary;

        #endregion

        #region Properties

        public double RealValue
        {
            get
            {
                return _realValue;
            }
        }

        public List<string> Binary
        {
            get
            {
                return _binary;
            }
        }
        public double dg
        {
            get;
            set;
        }
        public double gg
        {
            get;
            set;
        }


        #endregion

        #region Constructors

        public Chromosome(double encodedValue)
        {
            _realValue = encodedValue;
            _binary = new List<string>();
        }

        #endregion

        #region Methods

        public void Encode()
        {

        }
        public double Decode()
        {

            return _realValue;
        }

        #endregion
    }
}
