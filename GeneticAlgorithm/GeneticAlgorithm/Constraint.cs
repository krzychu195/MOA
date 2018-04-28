namespace GeneticAlgorithm
{
    public class Constraint
    {
        private int _lower;
        private int _upper;

        public Constraint(int lower, int upper)
        {
            _lower = lower;
            _upper = upper;
        }

        public int GetUpperConstraint()
        {
            return _upper;
        }
        public int GetLowerConstraint()
        {
            return _lower;
        }

        public void SetLowerConstraint(int value)
        {
            _lower = value;
        }

        public void SetUpperConstraint(int value)
        {
            _upper = value;
        }

    }
}
