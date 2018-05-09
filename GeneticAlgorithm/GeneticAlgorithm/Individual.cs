using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public class Individual
    {
        private decimal _f1;
        private decimal _f2;
        private List<double> _args;
        private double _crossingProbability;
        private double _mutationProbability;


        public Individual()
        {
            _args = new List<double>();
        }

        public Individual(List<double> args)
        {
            _args = new List<double>();
            _args = args;
        }

        public decimal GetValue1ForIndividual(FunctionStruct function1, FunctionStruct function2, List<double> args)
        {
            var f1 = new Parser(function1.GetFunctionBase(), function1.GetFunctionBody());
            f1.SetArguments(args);
            return Decimal.Round(Convert.ToDecimal(f1.GetResult()), 2);
        }


        public decimal GetValue2ForIndividual(FunctionStruct function1, FunctionStruct function2, List<double> args)
        {
            var f2 = new Parser(function2.GetFunctionBase(), function2.GetFunctionBody());
            f2.SetArguments(args);
            return Decimal.Round(Convert.ToDecimal(f2.GetResult()), 2);
        }

        public void Calculate(FunctionStruct function1, FunctionStruct function2)
        {
            var f1 = new Parser(function1.GetFunctionBase(), function1.GetFunctionBody());
            var f2 = new Parser(function2.GetFunctionBase(), function2.GetFunctionBody());
            f1.SetArguments(_args);
            f2.SetArguments(_args);

            _f1 = Decimal.Round(Convert.ToDecimal(f1.GetResult()), 2);
            _f2 = Decimal.Round(Convert.ToDecimal(f2.GetResult()), 2);
        }

        public void GenerateIndividual(FunctionStruct function1, FunctionStruct function2, List<double> x)
        {
            _args = x;
            var f1 = new Parser(function1.GetFunctionBase(), function1.GetFunctionBody());
            var f2 = new Parser(function2.GetFunctionBase(), function2.GetFunctionBody());
            f1.SetArguments(x);
            f2.SetArguments(x);
            var df1 = f1.GetResult();
            var df2 = f2.GetResult();
            try
            {
                _f1 = Decimal.Round((df1), 2);
                _f2 = Decimal.Round((df2), 2);
            }
            catch (OverflowException e)
            {
                MessageBox.Show(df1.ToString() + " | " + df2 + " : " + e);
            }
        }

        public void GenerateProbability()
        {
            Random random = new Random();
            _crossingProbability = random.NextDouble();
            _mutationProbability = random.NextDouble();
        }

        public double GetCrossingProbability()
        {
            return _crossingProbability;
        }

        public double GetMutationProbability()
        {
            return _mutationProbability;
        }

        public decimal GetFitness1()
        {
            return _f1;
        }
        public decimal GetFitness2()
        {
            return _f2;
        }

        public List<double> GetArgsVector()
        {
            return _args;
        }

        public void AddArgument(double argument)
        {
            _args.Add(argument);
        }
    }
}
