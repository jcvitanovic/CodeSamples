using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_Dz3_GA
{
    public static class Constants
    {
        public static double LOWERSEARCHBOUND = -100;
        public static double UPPERSEARCHBOUND = 100;
        public static int POPULATIONSIZE
        {
            get;
            set;
        }
        public static int ITERATIONNUM
        {
            get;
            set;
        }
        public static double MUTATIONPARAMETER
        {
            get;
            set;
        }

    }
}
