using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_Dz3_GA
{
    public static class Algorithm
    {
        public static readonly Random random = new Random();

        public static double GetRandomNumber(double minimum, double maximum)
        {

            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        public static void Run()
        {

            GeneticAlgorithm.Init();
            GeneticAlgorithm.Start();
        }
    }
}
