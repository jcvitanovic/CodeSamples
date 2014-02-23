using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text;
using System.IO;

namespace APR_Dz3_GA
{
    public static class GeneticAlgorithm
    {
        #region Properties

        public static int VectorDimension
        {
            get;
            set;
        }

        public static IFunction Function
        {
            get;
            set;
        }

        public static List<Vector> Population
        {
            get;
            set;
        }

        public static List<double> PopulationEvaluation
        {
            get;
            set;
        }

        #endregion

        #region Methods

        public static Vector CrossOver(Vector parent1, Vector parent2)
        {
            Vector child = new Vector();
            child.Dimension = VectorDimension;

            int randomNum = Algorithm.random.Next(0, VectorDimension);

            for (int i = 0; i < randomNum; i++)
            {
                int parent = Algorithm.random.Next(0, 1);
                if (parent == 0)
                    child.Components.Add(parent1.Components[i]);
                else
                    child.Components.Add(parent2.Components[i]);
            }
            for (int i = randomNum; i < VectorDimension; i++)
            {
                child.Components.Add((parent1.Components[i]) + (parent2.Components[i]) / 2);
            }
            return child;
        }

        public static Vector Mutation(Vector child)
        {
            for (int i = 0; i < VectorDimension; i++)
            {
                double mutation = Algorithm.GetRandomNumber(0, 1);
                if (mutation <= Constants.MUTATIONPARAMETER)
                {
                    int addSub = Algorithm.random.Next(0, 1);
                    if (addSub == 0)
                        child.Components[i] += Algorithm.GetRandomNumber(Constants.LOWERSEARCHBOUND / 2, Constants.UPPERSEARCHBOUND / 2);
                    else
                        child.Components[i] -= Algorithm.GetRandomNumber(Constants.LOWERSEARCHBOUND / 2, Constants.UPPERSEARCHBOUND / 2);

                    if (child.Components[i] > Constants.UPPERSEARCHBOUND)
                        child.Components[i] = Constants.UPPERSEARCHBOUND;
                    if (child.Components[i] < Constants.LOWERSEARCHBOUND)
                        child.Components[i] = Constants.LOWERSEARCHBOUND;
                }
            }
            return child;
        }

        public static void Init()
        {
            string line;
            string[] inputData;
            int dimensions, functionSelection;
            int populationSize, iterationNum;
            double mutation;
            string[] parameters;
            
            System.IO.StreamReader file = new System.IO.StreamReader("data.txt");
            line = file.ReadLine();
            inputData = line.Split(' ');
            dimensions = Convert.ToInt32(inputData[0]);
            VectorDimension = dimensions;
            functionSelection = Convert.ToInt32(inputData[1]);
            line = file.ReadLine();
            populationSize = Convert.ToInt32(line);
            line = file.ReadLine();
            inputData = line.Split(' ');
            mutation = double.Parse(inputData[0], CultureInfo.InvariantCulture);
            line = file.ReadLine();
            iterationNum = Convert.ToInt32(line);

            if (functionSelection == 3)
            {
                try
                {
                    Function = FunctionRepository.F3;
                    line = file.ReadLine();
                    parameters = line.Split(' ');
                    foreach (string p in parameters)
                    {
                        double param = double.Parse(p, CultureInfo.InvariantCulture);
                        (Function as F3).Parameters.Add(param);
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input data");
                    return;
                }

            }
            else if (functionSelection == 4)
            {
                Function = FunctionRepository.F4;
            }
            else if (functionSelection == 6)
            {
                Function = FunctionRepository.F6;
            }
            else if (functionSelection == 7)
            {
                Function = FunctionRepository.F7;
            }
            else
            {
                Console.WriteLine("Invalid input data");
                return;
            }

            Constants.ITERATIONNUM = iterationNum;
            Constants.POPULATIONSIZE = populationSize;
            Constants.MUTATIONPARAMETER = mutation;

            InitPopulation();
        }

        private static void InitPopulation()
        {
            Population = new List<Vector>();
            PopulationEvaluation = new List<double>();

            for(int i = 0; i<Constants.POPULATIONSIZE;i++)
            {
                Vector v = new Vector();
                v.Dimension = VectorDimension;
                for(int j=0; j<VectorDimension;j++)
                {
                    double randComponent = Algorithm.GetRandomNumber(Constants.LOWERSEARCHBOUND, Constants.UPPERSEARCHBOUND);
                    v.Components.Add(randComponent);
                }
                Population.Add(v);
                PopulationEvaluation.Add(Function.Calculate(v));
            }
        }

        public static void Start()
        {
            int GeneratonNum = 0;
            int IterationNum = 0;
            while (GeneratonNum < Constants.ITERATIONNUM)
            {

                if (GeneratonNum % 1000 == 0 && IterationNum % Constants.POPULATIONSIZE == 0)
                {
                    Console.WriteLine("(Generation:{0})\n    Best unit value:\n    {1}", GeneratonNum, PopulationEvaluation.Min());
                    int index = PopulationEvaluation.IndexOf(PopulationEvaluation.Min());
                    Console.WriteLine("    Best unit: ");
                    Console.Write("    ");
                    for(int i=0;i<VectorDimension;i++)
                    {
                        Console.Write("{0} ", Population[index].Components[i]);
                    }
                    Console.WriteLine("");
                }

                int childIndex = Algorithm.random.Next(0, Constants.POPULATIONSIZE);
                int parent1, parent2;
                while ((parent1 = Algorithm.random.Next(0, Constants.POPULATIONSIZE)) == childIndex)
                    parent1 = Algorithm.random.Next(0, Constants.POPULATIONSIZE);
                while ((parent2 = Algorithm.random.Next(0, Constants.POPULATIONSIZE)) == childIndex || parent2 == parent1)
                    parent2 = Algorithm.random.Next(0, Constants.POPULATIONSIZE);

                if (PopulationEvaluation[parent1] > PopulationEvaluation[childIndex])
                {
                    int tmp;
                    tmp = childIndex;
                    childIndex = parent1;
                    parent1 = tmp;
                }
                if (PopulationEvaluation[parent2] > PopulationEvaluation[childIndex])
                {
                    int tmp;
                    tmp = childIndex;
                    childIndex = parent2;
                    parent2 = tmp;
                }
                Population[childIndex] = CrossOver(Population[parent1], Population[parent2]);
                Population[childIndex] = Mutation(Population[childIndex]);
                PopulationEvaluation[childIndex] = Function.Calculate(Population[childIndex]);
                IterationNum++;
                if (IterationNum == Constants.POPULATIONSIZE)
                {
                    GeneratonNum++;
                    IterationNum = 0;
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("(Finally)\n    Best unit value:\n    {0}",  PopulationEvaluation.Min());
            int indx = PopulationEvaluation.IndexOf(PopulationEvaluation.Min());
            Console.WriteLine("    Best unit: ");
            Console.Write("    ");
            for (int i = 0; i < VectorDimension; i++)
            {
                Console.Write("{0} ", Population[indx].Components[i]);
            }
            Console.WriteLine("");
            return;

        }

        #endregion
    }
}
