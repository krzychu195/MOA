using System;
using System.Collections.Generic;
using org.mariuszgromada.math.mxparser;


namespace GeneticAlgorithm
{
    public class Parser
    {
        private Expression _expression;
        private Function f;
        private readonly string _base;
        private List<Argument> _x;
        
        public Parser(string fBase, string function)
        {
            _base = fBase;
            f = new Function(_base+"="+function);
        }
        
        public void SetArguments(List<double> argumentsValues)
        {
            _x = new List<Argument>();
            var argsNumber = argumentsValues.Count;
            for (int i = 1; i < argsNumber + 1; i++)
                _x.Add(new Argument("x" + i, argumentsValues[i-1]));
            if (argsNumber == 1)
            {
                _expression = new Expression(_base, f, _x[0]);
            }
            if(argsNumber==2)
            {
                _expression = new Expression(_base, f, _x[0], _x[1]);
            }
            if (argsNumber == 3)
            {
                _expression = new Expression(_base, f, _x[0], _x[1], _x[2]);
            }
            if (argsNumber == 4)
            {
                _expression = new Expression(_base, f, _x[0], _x[1], _x[2], _x[3]);
            }
            if (argsNumber == 5)
            {
                _expression = new Expression(_base, f, _x[0], _x[1], _x[2], _x[3], _x[4]);
            }
        }

        public decimal GetResult()
        {
            return (decimal)_expression.calculate();
        }

    }
}
