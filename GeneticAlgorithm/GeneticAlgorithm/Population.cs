using System.Collections.Generic;

namespace GeneticAlgorithm
{
    public class Population
    {
        private List<Individual> _population;

        public Population()
        {
            _population = new List<Individual>();
        }

        public Population(List<Individual> population)
        {
            _population = new List<Individual>();
            _population = population;
        }

        public void GeneratePopulationOfSize(FunctionStruct function1, FunctionStruct function2, Constraints constraints, int N)
        {
            for (var i = 0; i < N; i++)
            {
                var args = constraints.GenerateArguments();
                var individual = new Individual();
                individual.GenerateIndividual(function1, function2, args);
                _population.Add(individual);
            }
        }        

        public Individual GetIndividual(int i)
        {
            return _population[i];
        }

        public void Add(Individual population)
        {
            _population.Add(population);
        }

        public List<Population> DevidePopulation()
        {
            var FirstSet = new Population();
            var SecondSet = new Population();
            var populationMiddle = _population.Count / 2;

            for (var i = 0; i < populationMiddle; i++)
            {
                FirstSet.Add(_population[i]);
            }

            for (var i = populationMiddle; i < _population.Count; i++)
            {
                SecondSet.Add(_population[i]);
            }

            var devidedPopulations = new List<Population> {FirstSet, SecondSet};

            return devidedPopulations;
        }

        public void SortF1()
        {
            _population.Sort((ind1, ind2) => ind1.GetFitness1().CompareTo(ind2.GetFitness1()));
        }
        public void SortF2()
        {
            _population.Sort((ind1, ind2) => ind1.GetFitness2().CompareTo(ind2.GetFitness2()));
        }

        public int Size()
        {
            return _population.Count;
        }

        public void DeleteIndividual(int i)
        {
            _population.RemoveAt(i);
        }

        public void GenerateProbabilities()
        {
            for (var i = 0; i < _population.Count; i++)
            {
                _population[i].GenerateProbability();
            }
        }

        public List<Individual> GetPopulation()
        {
            return _population;
        }

    }
}
