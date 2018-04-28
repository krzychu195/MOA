using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class Form1 : Form
    {
        private Parser _parser1;
        private Parser _parser2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FunctionStruct functionStruct1= new FunctionStruct("f(x1,x2,x3)", func1.Text);
            FunctionStruct functionStruct2 = new FunctionStruct("f(x1,x2,x3)", func2.Text);

            //_parser1 = new Parser("f(x1,x2,x3)", func1.Text);
            //_parser1.SetArguments(new List<int> { 0, 1, 2 });
            //_parser2 = new Parser("f(x1,x2,x3)", func2.Text);
            //_parser2.SetArguments(new List<int> { 0, 1, 2 });
            //var f1value = _parser1.GetResult();
            //var f2value = _parser2.GetResult();
            Constraints constraints = new Constraints(new[] {-5, -4, -7}, new[] {5, 4, 7});

            Vega vega = new Vega(10,4, 0.7, 0.6, functionStruct1, functionStruct2, constraints);
            vega.Initialization();
            var result = vega.Evaluate();
        }

    }
}
