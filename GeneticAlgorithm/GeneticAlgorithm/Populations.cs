using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Populations
    {
        private readonly List<Population> _populations;

        public Populations(List<Population> populations)
        {
            _populations = populations;
        }

        public Population GetIndividual()
        {
            return new Population();
        }

        public void Add(Population population)
        {
            _populations.Add(population);
        }
    }
}
