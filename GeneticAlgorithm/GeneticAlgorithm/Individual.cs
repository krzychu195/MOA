using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public class Individual
    {
        private double _f1;
        private double _f2;
        private List<int> _args;

        public Individual()
        {
            _args = new List<int>();
        }

        public Individual(List<int> args)
        {
            _args = new List<int>();
            _args = args;
        }

        public void Calculate(FunctionStruct function1, FunctionStruct function2)
        {
            var f1 = new Parser(function1.GetFunctionBase(), function1.GetFunctionBody());
            var f2 = new Parser(function2.GetFunctionBase(), function2.GetFunctionBody());
            f1.SetArguments(_args);
            f2.SetArguments(_args);

            _f1 = f1.GetResult();
            _f2 = f2.GetResult();
        }

        public void GenerateIndividual(FunctionStruct function1, FunctionStruct function2, List<int> x)
        {
            _args = x;
            var f1 = new Parser(function1.GetFunctionBase(), function1.GetFunctionBody());
            var f2 = new Parser(function2.GetFunctionBase(), function2.GetFunctionBody());
            f1.SetArguments(x);
            f2.SetArguments(x);

            _f1 = f1.GetResult();
            _f2 = f2.GetResult();
        }

        public double GetFitness1()
        {
            return _f1;
        }
        public double GetFitness2()
        {
            return _f2;
        }

        public List<int> GetArgsVector()
        {
            return _args;
        }

        public void AddArgument(int argument)
        {
            _args.Add(argument);
        }
    }
}
