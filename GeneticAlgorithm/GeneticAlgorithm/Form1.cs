using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            FunctionStruct functionStruct1= new FunctionStruct(comboBox1.SelectedItem.ToString(), func1.Text);
            FunctionStruct functionStruct2 = new FunctionStruct(comboBox1.SelectedItem.ToString(), func2.Text);

            Constraints constraints = new Constraints(new[] {-5, -4, -7}, new[] {5, 4, 7});

            Vega vega = new Vega(int.Parse(popSize.Text), int.Parse(iterations.Text),
                Double.Parse(crossingPb.Text, CultureInfo.InvariantCulture),
                Double.Parse(mutationPb.Text, CultureInfo.InvariantCulture), functionStruct1, functionStruct2,
                constraints);
            vega.Initialization();
            var result = vega.Iterate();

            chart1.Series["Series1"].ChartType = SeriesChartType.Point;
            for(var i=0;i<result.Size();i++)
            {
                chart1.Series["Series1"].Points.AddXY(result.GetIndividual(i).GetFitness1(),
                    result.GetIndividual(i).GetFitness2());
            }
        }
    }
}
