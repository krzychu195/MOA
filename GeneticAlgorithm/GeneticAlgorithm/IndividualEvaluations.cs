using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class IndividualEvaluations
    {
        private List<Individual> _crossedIndividuals;

        public Individual Mutate(Individual individual)
        {
            Random random = new Random();
            var gen1 = random.Next(individual.GetArgsVector().Count);
            var gen2 = random.Next(individual.GetArgsVector().Count);
            if (gen2 == gen1)
            {
                while (gen2 != gen1)
                    gen2 = random.Next(individual.GetArgsVector().Count);
            }

            var temp = individual.GetArgsVector()[gen1];
            individual.GetArgsVector()[gen1] = individual.GetArgsVector()[gen2];
            individual.GetArgsVector()[gen2] = temp;

            return individual;
        }

        public List<Individual> Cross(Individual individual1, Individual individual2)
        {
            var newIndividual1 = new Individual();
            var newIndividual2 = new Individual();

            _crossedIndividuals = new List<Individual>();
            Random random = new Random();
            var crossingPoint = random.Next(individual1.GetArgsVector().Count);

            for (var i = 0; i < crossingPoint; i++)
            {
                newIndividual1.AddArgument(individual1.GetArgsVector()[i]);
                newIndividual2.AddArgument(individual2.GetArgsVector()[i]);
            }

            for (var j = crossingPoint; j < individual1.GetArgsVector().Count; j++)
            {
                newIndividual1.AddArgument(individual2.GetArgsVector()[j]);
                newIndividual2.AddArgument(individual1.GetArgsVector()[j]);
            }
            _crossedIndividuals.Add(newIndividual1);
            _crossedIndividuals.Add(newIndividual2);
            
            return _crossedIndividuals;
        }
    }
}
