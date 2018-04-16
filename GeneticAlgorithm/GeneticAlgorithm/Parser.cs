using org.mariuszgromada.math.mxparser;


namespace GeneticAlgorithm
{
    public class Parser
    {
        private Function f;
        private Expression _expression;

        public Parser(string expression, string body, int _x1, int _x2, Function function)
        {
            f = new Function("f(x1,x2)=" + expression);
            var x1 = new Argument("x1="+_x1);
            var x2 = new Argument("x2=" + _x2);
            _expression = new Expression(body, f, x1, x2);
        }
    }
}
