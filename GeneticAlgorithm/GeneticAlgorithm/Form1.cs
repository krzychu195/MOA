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
            chart1.Legends.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FunctionStruct functionStruct1= new FunctionStruct(comboBox1.SelectedItem.ToString(), func1.Text);
            FunctionStruct functionStruct2 = new FunctionStruct(comboBox1.SelectedItem.ToString(), func2.Text);

            tbResult.Clear();
            chart1.Series["Series1"].Points.Clear();
            


            int lo = 0;
            int up = 0;
            int[] lotab = new int[5];
            int[] uptab = new int[5];

            for (int i = 0; i <= comboBox1.SelectedIndex; i++)
            {
                switch (i)
                {
                    case 0:
                        lo = int.Parse(tbL1.Text);
                        up = int.Parse(tbU1.Text);
                        break;
                    case 1:
                        lo = int.Parse(tbL2.Text);
                        up = int.Parse(tbU2.Text);
                        break;
                    case 2:
                        lo = int.Parse(tbL3.Text);
                        up = int.Parse(tbU3.Text);
                        break;
                    case 3:
                        lo = int.Parse(tbL4.Text);
                        up = int.Parse(tbU4.Text);
                        break;
                    case 4:
                        lo = int.Parse(tbL5.Text);
                        up = int.Parse(tbU5.Text);
                        break;
                }
                lotab[i] = lo;
                uptab[i] = up;
            }

            Constraints constraints = new Constraints(lotab, uptab);

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
                tbResult.AppendText(result.GetIndividual(i).GetFitness1().ToString()+"     ");
                tbResult.AppendText(result.GetIndividual(i).GetFitness2().ToString()+"\n");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int l = 0;
            int u = 0;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    lbL.Visible = true; lbU.Visible = true;
                    lbX1.Visible = true; tbL1.Visible = true; tbU1.Visible = true;
                    lbX2.Visible = false; tbL2.Visible = false; tbU2.Visible = false;
                    lbX3.Visible = false; tbL3.Visible = false; tbU3.Visible = false;
                    lbX4.Visible = false; tbL4.Visible = false; tbU4.Visible = false;
                    lbX5.Visible = false; tbL5.Visible = false; tbU5.Visible = false;
                    break;
                case 1:
                    lbL.Visible = true; lbU.Visible = true;
                    lbX1.Visible = true; tbL1.Visible = true; tbU1.Visible = true;
                    lbX2.Visible = true; tbL2.Visible = true; tbU2.Visible = true;
                    lbX3.Visible = false; tbL3.Visible = false; tbU3.Visible = false;
                    lbX4.Visible = false; tbL4.Visible = false; tbU4.Visible = false;
                    lbX5.Visible = false; tbL5.Visible = false; tbU5.Visible = false;
                    break;
                case 2:
                    lbL.Visible = true; lbU.Visible = true;
                    lbX1.Visible = true; tbL1.Visible = true; tbU1.Visible = true;
                    lbX2.Visible = true; tbL2.Visible = true; tbU2.Visible = true;
                    lbX3.Visible = true; tbL3.Visible = true; tbU3.Visible = true;
                    lbX4.Visible = false; tbL4.Visible = false; tbU4.Visible = false;
                    lbX5.Visible = false; tbL5.Visible = false; tbU5.Visible = false;
                    break;
                case 3:
                    lbL.Visible = true; lbU.Visible = true;
                    lbX1.Visible = true; tbL1.Visible = true; tbU1.Visible = true;
                    lbX2.Visible = true; tbL2.Visible = true; tbU2.Visible = true;
                    lbX3.Visible = true; tbL3.Visible = true; tbU3.Visible = true;
                    lbX4.Visible = true; tbL4.Visible = true; tbU4.Visible = true;
                    lbX5.Visible = false; tbL5.Visible = false; tbU5.Visible = false;
                    break;
                case 4:
                    lbL.Visible = true; lbU.Visible = true;
                    lbX1.Visible = true; tbL1.Visible = true; tbU1.Visible = true;
                    lbX2.Visible = true; tbL2.Visible = true; tbU2.Visible = true;
                    lbX3.Visible = true; tbL3.Visible = true; tbU3.Visible = true;
                    lbX4.Visible = true; tbL4.Visible = true; tbU4.Visible = true;
                    lbX5.Visible = true; tbL5.Visible = true; tbU5.Visible = true;
                    break;

            }
        }
        
    }
}
