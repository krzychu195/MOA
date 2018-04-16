using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class Population
    {
        private int _x;
        private int _y;
        private Parser DestinationFunction { get; set; }

        public Population(Parser parser)
        {
            DestinationFunction = parser;
        }

        public Population(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public float getFitness()//zwraca nie wiem co :) trzeba ogarnąć czym jest dopasowanie
        // w oparciu o funkcję celu więc możliwe, że ona będzie argumentem
        {
            return DestinationFunction.Expression("");
        }
    }
}
