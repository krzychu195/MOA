using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithm
{
    public class Constraints
    {
        private List<Constraint> _constraints;

        public Constraints(int[] l, int[] u)
        {
            _constraints = new List<Constraint>();
            for (int i = 0; i < l.Length; i++)
            {
                var constraint = new Constraint(l[i], u[i]);
                _constraints.Add(constraint);
            }
        }

        public List<int> GenerateArguments()
        {
            var random = new Random();

            return _constraints.Select(t => random.Next(t.GetLowerConstraint(), t.GetUpperConstraint())).ToList();
        }
    }
}
