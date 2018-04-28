namespace GeneticAlgorithm
{
    public class FunctionStruct
    {
        private string _base;
        private string _body;

        public FunctionStruct(string fbase, string body)
        {
            _base = fbase;
            _body = body;
        }

        public string GetFunctionBase()
        {
            return _base;
        }

        public string GetFunctionBody()
        {
            return _body;
        }

    }
}
