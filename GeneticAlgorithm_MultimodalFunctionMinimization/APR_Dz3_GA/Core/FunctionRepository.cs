using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_Dz3_GA
{
    public static class FunctionRepository
    {
        #region Fields

        private static IFunction f3 = new F3();
        private static IFunction f4 = new F4();
        private static IFunction f6 = new F6();
        private static IFunction f7 = new F7();

        #endregion

        #region Properties

        public static IFunction F3
        {
            get
            {
                return f3;
            }
        }

        public static IFunction F4
        {
            get
            {
                return f4;
            }
        }

        public static IFunction F6
        {
            get
            {
                return f6;
            }
        }

        public static IFunction F7
        {
            get
            {
                return f7;
            }
        }

        #endregion
    }
}
