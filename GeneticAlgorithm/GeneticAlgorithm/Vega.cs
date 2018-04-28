using System;
using System.Collections.Generic;

namespace GeneticAlgorithm
{
    public class Vega
    {
        private readonly Population _beginingPopulation;
        private int _numberOfGeneration;
        private readonly int _populationSize;
        private int _numberOfCriterions;
        private readonly Population _matingPool;
        private FunctionStruct _function1;
        private FunctionStruct _function2;
        private Constraints _constraints;// zamienic no ograniczenia i wszedzie bedzie trzeba losować argumenty. Spowrotem dodać liste argumentów do individual
        private List<Population> _subPopulations;
        private Population _populationAfterCrossing;
        private Population _populationAfterMutation;
        private double _crossingProbability;
        private double _mutationProbability;

        public Vega(int populationSize, int generationsLimit, double crossingProbability, double mutationProbability,
            FunctionStruct function1, FunctionStruct function2, Constraints constraints)
        {
            _populationSize = populationSize;
            _crossingProbability = crossingProbability;
            _mutationProbability = mutationProbability;
            _function1 = function1;
            _function2 = function2;
            _constraints = constraints;
            _beginingPopulation = new Population();
            _numberOfGeneration = 0;
            _matingPool = new Population();
        }

        public void Initialization()
        {
            _beginingPopulation.GeneratePopulationOfSize(_function1, _function2, _constraints, _populationSize);
        }

        public Population SetFitnessAndSelection()
        {
            double selectionPercentage = 0.8;

            int numberOfCiterions = 2;
            _subPopulations = _beginingPopulation.DevidePopulation();

            _subPopulations[0].SortF1();
            _subPopulations[1].SortF2();

            for (int i = 0; i < numberOfCiterions; i++)
            {
                for (int j = 0; j < (int)_subPopulations[i].Size()*selectionPercentage; j++)
                {
                    if (i == 0)
                    {
                        _matingPool.Add(_subPopulations[i].GetIndividual(j));
                    }
                    else
                    {
                        _matingPool.Add(_subPopulations[i].GetIndividual(j));
                    }
                }
            }

            return _matingPool;
        }

        public void Recombinate()
        {
            //zaimplementować prawdopodobieństwo krzyżowania
      
            IndividualEvaluations evaluations = new IndividualEvaluations();
            Random random = new Random();
            _populationAfterCrossing = new Population();

            for (var i = 0; i < _matingPool.Size()/2; i++)
            {
                var chosenIndividual1 = random.Next(_matingPool.Size());
                var chosenIndividual2 = random.Next(_matingPool.Size());
                var newIndividuals = evaluations.Cross(_matingPool.GetIndividual(chosenIndividual1), _matingPool.GetIndividual(chosenIndividual2));

                if (_crossingProbability < 1)
                {
                    _populationAfterCrossing.Add(newIndividuals[0]);
                    _populationAfterCrossing.Add(newIndividuals[1]);
                }
                else
                {
                    _populationAfterCrossing.Add(_matingPool.GetIndividual(chosenIndividual1));
                    _populationAfterCrossing.Add(_matingPool.GetIndividual(chosenIndividual2));
                }

                _matingPool.DeleteIndividual(chosenIndividual1);
                _matingPool.DeleteIndividual(chosenIndividual2);
            }
        }

        public void Mutation()
        {
            IndividualEvaluations evaluations = new IndividualEvaluations();
            _populationAfterMutation = new Population();

            for (var i = 0; i < _populationAfterCrossing.Size(); i++)
            {
                // dodac prawdopodob mutacji
               _populationAfterMutation.Add(evaluations.Mutate(_populationAfterCrossing.GetIndividual(i)));
               _populationAfterMutation.GetIndividual(i).Calculate(_function1, _function2);
            }
        }

        public Population Evaluate()
        {
            SetFitnessAndSelection();
            Recombinate();
            Mutation();
            return _populationAfterMutation;
        }
    }
}
