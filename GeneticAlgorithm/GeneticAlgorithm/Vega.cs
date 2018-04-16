using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Vega
    {
        private readonly Populations _beginingPopulation; // jakis IEnumerable<>
        private int _numberOfGeneration;
        private readonly int _populationSize;
        private int _numberOfCriterions;
        private readonly Populations _matingPool;

        public Vega(int populationSize, int generationsLimit, float crossingProbability, float mutationProbability, ) //would be better to provide IMoa interface thru 
        //dependancy injection, but in the future  // public Vega(IMoa moa){_moa = moa} 
        {
            //populationSize - population size
            // generationLimit - maksimum number of generations
            //archive - set of nondominated results
            // crossing probability
            // mutation probability
            _populationSize = populationSize;
            _beginingPopulation = null;
            _numberOfGeneration = 0;
            _matingPool = null;
        }

        public Populations Initialization() // generation of begining population
        {
            for (int i = 0; i < _populationSize; i++)// lub Population.Size() trzeba pomyśleć ale tak chyba właśnie byłoby lepiej
            // i do konstruktora przekazywać cały obiekt Population i w tej klasy konstruktorze inicjalizować rozmiar.
            {
                _beginingPopulation.Add(GenerateIndividual());
            } 
            return _beginingPopulation;  // pobieranie osobnika i dodanie do populacji poczatkowej
            //an iteration of algorithm
        }

        public void SetFitnessAndSelection(int numberOfCiterions) // nie wiem skad ten argument sie bierze
        {
            for (int i = 0; i < numberOfCiterions; i++)
            {
                _beginingPopulation.GetIndividual().getFitness();
            }

            for (int j = 0; j < _populationSize / numberOfCiterions; j++)
            {
                _matingPool.Add(GetIndividual());
            }
        }

        public void Evaluate()
        {
            //return NondominatedPopulation archive;
        }

        public Population GenerateIndividual()
        {
            return new Population();// dodac implementacje
        }

        // trzeba chyba bedzie pomyslec o zrobieniu klasy Poplations która jest IEnumerable<Population> i tam stworzyć taką
        //metodę jak ponizej
        public Population GetIndividual() 
        {
            return new Population();
        }

    }
}
