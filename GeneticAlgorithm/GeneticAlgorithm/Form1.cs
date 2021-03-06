﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Legends.Clear();
            chart2.Legends.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FunctionStruct functionStruct1= new FunctionStruct(comboBox1.SelectedItem.ToString(), func1.Text);
            FunctionStruct functionStruct2 = new FunctionStruct(comboBox1.SelectedItem.ToString(), func2.Text);
            Population nonDominatedPopulation = new Population();

            //chart2.Visible = false;
            chart1.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.Clear();
            //chart1.ChartAreas[0].AxisX.RoundAxisValues();
            dataGridView1.Rows.Clear();


            int lo = 0;
            int up = 0;

            int[] lotab = new int[comboBox1.SelectedIndex+1];
            int[] uptab = new int[comboBox1.SelectedIndex+1];

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
            var index = 0;
            if (result.GetIndividual(0).GetFitness2() < result.GetIndividual(1).GetFitness2())
            { 
                nonDominatedPopulation.Add(result.GetIndividual(0));
            }
            else
            {
                nonDominatedPopulation.Add(result.GetIndividual(1));
                index = 1;
            }
            result.SortF1();
            chart2.Series["Series1"].ChartType = SeriesChartType.Point;

            for (var i = 0; i < result.Size(); i++)
            {
                chart2.Series["Series1"].Points.AddXY(result.GetIndividual(i).GetFitness1(),
                    result.GetIndividual(i).GetFitness2());
            }

            for (var i = 1; i < result.Size(); i++)
            {
                if (result.GetIndividual(i).GetFitness2() < nonDominatedPopulation.GetIndividual(nonDominatedPopulation.Size() - 1).GetFitness2())
                {
                    nonDominatedPopulation.Add(result.GetIndividual(i));
                }
            }

            if (nonDominatedPopulation.GetIndividual(0).GetFitness1() > nonDominatedPopulation.GetIndividual(1).GetFitness1())
            {
                nonDominatedPopulation.DeleteIndividual(0);
            }


            chart1.Series["Series1"].ChartType = SeriesChartType.Point;
            for(var i=0;i< nonDominatedPopulation.Size();i++)
            {
                string[] mystring = new string[] { "", "", "", "", "", "", "" };
                chart1.Series["Series1"].Points.AddXY(nonDominatedPopulation.GetIndividual(i).GetFitness1(),
                    nonDominatedPopulation.GetIndividual(i).GetFitness2());
                mystring[0] = nonDominatedPopulation.GetIndividual(i).GetFitness1().ToString();
                mystring[1] = nonDominatedPopulation.GetIndividual(i).GetFitness2().ToString();
                for (var j=0;j< nonDominatedPopulation.GetIndividual(i).GetArgsVector().Count; j++)
                {
                    mystring[j+2] = Math.Round(nonDominatedPopulation.GetIndividual(i).GetArgsVector()[j],3).ToString();
                }
                dataGridView1.Rows.Add(mystring);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void button3_Click(object sender, EventArgs e)
        {
            //chart2.Visible = false;
            chart1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            //chart2.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            chart1.Visible = false;
            chart2.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart2.Visible = false;
        }
    }
}
