namespace GeneticAlgorithm
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.func1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.func2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.popSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iterations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.crossingPb = new System.Windows.Forms.TextBox();
            this.mutationPb = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbX1 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.lbX3 = new System.Windows.Forms.Label();
            this.lbX4 = new System.Windows.Forms.Label();
            this.lbX5 = new System.Windows.Forms.Label();
            this.lbL = new System.Windows.Forms.Label();
            this.lbU = new System.Windows.Forms.Label();
            this.tbL1 = new System.Windows.Forms.TextBox();
            this.tbU1 = new System.Windows.Forms.TextBox();
            this.tbL2 = new System.Windows.Forms.TextBox();
            this.tbU2 = new System.Windows.Forms.TextBox();
            this.tbL3 = new System.Windows.Forms.TextBox();
            this.tbU3 = new System.Windows.Forms.TextBox();
            this.tbL4 = new System.Windows.Forms.TextBox();
            this.tbU4 = new System.Windows.Forms.TextBox();
            this.tbL5 = new System.Windows.Forms.TextBox();
            this.tbU5 = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1050, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // func1
            // 
            this.func1.Location = new System.Drawing.Point(142, 63);
            this.func1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.func1.Name = "func1";
            this.func1.Size = new System.Drawing.Size(148, 26);
            this.func1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Funkcja celu 1";
            // 
            // func2
            // 
            this.func2.Location = new System.Drawing.Point(142, 105);
            this.func2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.func2.Name = "func2";
            this.func2.Size = new System.Drawing.Size(148, 26);
            this.func2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Funkcja celu 2";
            // 
            // popSize
            // 
            this.popSize.Location = new System.Drawing.Point(142, 146);
            this.popSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.popSize.Name = "popSize";
            this.popSize.Size = new System.Drawing.Size(148, 26);
            this.popSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rozmiar populacji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ilość iteracji";
            // 
            // iterations
            // 
            this.iterations.Location = new System.Drawing.Point(142, 186);
            this.iterations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(148, 26);
            this.iterations.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pb krzyżowania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pb mutacji";
            // 
            // crossingPb
            // 
            this.crossingPb.Location = new System.Drawing.Point(142, 226);
            this.crossingPb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crossingPb.Name = "crossingPb";
            this.crossingPb.Size = new System.Drawing.Size(148, 26);
            this.crossingPb.TabIndex = 11;
            // 
            // mutationPb
            // 
            this.mutationPb.Location = new System.Drawing.Point(142, 266);
            this.mutationPb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mutationPb.Name = "mutationPb";
            this.mutationPb.Size = new System.Drawing.Size(148, 26);
            this.mutationPb.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(302, 18);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(718, 526);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Postać funkcji";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "f(x1)",
            "f(x1,x2)",
            "f(x1,x2,x3)",
            "f(x1,x2,x3,x4)",
            "f(x1,x2,x3,x4,x5)"});
            this.comboBox1.Location = new System.Drawing.Point(142, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.Location = new System.Drawing.Point(18, 393);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(25, 20);
            this.lbX1.TabIndex = 16;
            this.lbX1.Text = "x1";
            this.lbX1.Visible = false;
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.Location = new System.Drawing.Point(18, 422);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(25, 20);
            this.lbX2.TabIndex = 17;
            this.lbX2.Text = "x2";
            this.lbX2.Visible = false;
            // 
            // lbX3
            // 
            this.lbX3.AutoSize = true;
            this.lbX3.Location = new System.Drawing.Point(18, 454);
            this.lbX3.Name = "lbX3";
            this.lbX3.Size = new System.Drawing.Size(25, 20);
            this.lbX3.TabIndex = 18;
            this.lbX3.Text = "x3";
            this.lbX3.Visible = false;
            // 
            // lbX4
            // 
            this.lbX4.AutoSize = true;
            this.lbX4.Location = new System.Drawing.Point(18, 489);
            this.lbX4.Name = "lbX4";
            this.lbX4.Size = new System.Drawing.Size(25, 20);
            this.lbX4.TabIndex = 19;
            this.lbX4.Text = "x4";
            this.lbX4.Visible = false;
            // 
            // lbX5
            // 
            this.lbX5.AutoSize = true;
            this.lbX5.Location = new System.Drawing.Point(18, 521);
            this.lbX5.Name = "lbX5";
            this.lbX5.Size = new System.Drawing.Size(25, 20);
            this.lbX5.TabIndex = 20;
            this.lbX5.Text = "x5";
            this.lbX5.Visible = false;
            // 
            // lbL
            // 
            this.lbL.AutoSize = true;
            this.lbL.Location = new System.Drawing.Point(101, 353);
            this.lbL.Name = "lbL";
            this.lbL.Size = new System.Drawing.Size(18, 20);
            this.lbL.TabIndex = 21;
            this.lbL.Text = "L";
            this.lbL.Visible = false;
            // 
            // lbU
            // 
            this.lbU.AutoSize = true;
            this.lbU.Location = new System.Drawing.Point(221, 353);
            this.lbU.Name = "lbU";
            this.lbU.Size = new System.Drawing.Size(21, 20);
            this.lbU.TabIndex = 22;
            this.lbU.Text = "U";
            this.lbU.Visible = false;
            // 
            // tbL1
            // 
            this.tbL1.Location = new System.Drawing.Point(44, 390);
            this.tbL1.Name = "tbL1";
            this.tbL1.Size = new System.Drawing.Size(120, 26);
            this.tbL1.TabIndex = 23;
            this.tbL1.Text = "-5";
            this.tbL1.Visible = false;
            // 
            // tbU1
            // 
            this.tbU1.Location = new System.Drawing.Point(170, 390);
            this.tbU1.Name = "tbU1";
            this.tbU1.Size = new System.Drawing.Size(120, 26);
            this.tbU1.TabIndex = 24;
            this.tbU1.Text = "5";
            this.tbU1.Visible = false;
            // 
            // tbL2
            // 
            this.tbL2.Location = new System.Drawing.Point(44, 422);
            this.tbL2.Name = "tbL2";
            this.tbL2.Size = new System.Drawing.Size(120, 26);
            this.tbL2.TabIndex = 25;
            this.tbL2.Text = "-5";
            this.tbL2.Visible = false;
            // 
            // tbU2
            // 
            this.tbU2.Location = new System.Drawing.Point(170, 422);
            this.tbU2.Name = "tbU2";
            this.tbU2.Size = new System.Drawing.Size(120, 26);
            this.tbU2.TabIndex = 26;
            this.tbU2.Text = "5";
            this.tbU2.Visible = false;
            // 
            // tbL3
            // 
            this.tbL3.Location = new System.Drawing.Point(44, 454);
            this.tbL3.Name = "tbL3";
            this.tbL3.Size = new System.Drawing.Size(120, 26);
            this.tbL3.TabIndex = 27;
            this.tbL3.Text = "-5";
            this.tbL3.Visible = false;
            // 
            // tbU3
            // 
            this.tbU3.Location = new System.Drawing.Point(170, 454);
            this.tbU3.Name = "tbU3";
            this.tbU3.Size = new System.Drawing.Size(120, 26);
            this.tbU3.TabIndex = 28;
            this.tbU3.Text = "5";
            this.tbU3.Visible = false;
            // 
            // tbL4
            // 
            this.tbL4.Location = new System.Drawing.Point(44, 486);
            this.tbL4.Name = "tbL4";
            this.tbL4.Size = new System.Drawing.Size(120, 26);
            this.tbL4.TabIndex = 29;
            this.tbL4.Text = "-5";
            this.tbL4.Visible = false;
            // 
            // tbU4
            // 
            this.tbU4.Location = new System.Drawing.Point(170, 486);
            this.tbU4.Name = "tbU4";
            this.tbU4.Size = new System.Drawing.Size(120, 26);
            this.tbU4.TabIndex = 30;
            this.tbU4.Text = "5";
            this.tbU4.Visible = false;
            // 
            // tbL5
            // 
            this.tbL5.Location = new System.Drawing.Point(44, 518);
            this.tbL5.Name = "tbL5";
            this.tbL5.Size = new System.Drawing.Size(120, 26);
            this.tbL5.TabIndex = 31;
            this.tbL5.Text = "-5";
            this.tbL5.Visible = false;
            // 
            // tbU5
            // 
            this.tbU5.Location = new System.Drawing.Point(170, 518);
            this.tbU5.Name = "tbU5";
            this.tbU5.Size = new System.Drawing.Size(120, 26);
            this.tbU5.TabIndex = 32;
            this.tbU5.Text = "5";
            this.tbU5.Visible = false;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(1027, 68);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(170, 473);
            this.tbResult.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbU5);
            this.Controls.Add(this.tbL5);
            this.Controls.Add(this.tbU4);
            this.Controls.Add(this.tbL4);
            this.Controls.Add(this.tbU3);
            this.Controls.Add(this.tbL3);
            this.Controls.Add(this.tbU2);
            this.Controls.Add(this.tbL2);
            this.Controls.Add(this.tbU1);
            this.Controls.Add(this.tbL1);
            this.Controls.Add(this.lbU);
            this.Controls.Add(this.lbL);
            this.Controls.Add(this.lbX5);
            this.Controls.Add(this.lbX4);
            this.Controls.Add(this.lbX3);
            this.Controls.Add(this.lbX2);
            this.Controls.Add(this.lbX1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.mutationPb);
            this.Controls.Add(this.crossingPb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iterations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.popSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.func2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.func1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox func1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox func2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox popSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iterations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox crossingPb;
        private System.Windows.Forms.TextBox mutationPb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.Label lbX3;
        private System.Windows.Forms.Label lbX4;
        private System.Windows.Forms.Label lbX5;
        private System.Windows.Forms.Label lbL;
        private System.Windows.Forms.Label lbU;
        private System.Windows.Forms.TextBox tbL1;
        private System.Windows.Forms.TextBox tbU1;
        private System.Windows.Forms.TextBox tbL2;
        private System.Windows.Forms.TextBox tbU2;
        private System.Windows.Forms.TextBox tbL3;
        private System.Windows.Forms.TextBox tbU3;
        private System.Windows.Forms.TextBox tbL4;
        private System.Windows.Forms.TextBox tbU4;
        private System.Windows.Forms.TextBox tbL5;
        private System.Windows.Forms.TextBox tbU5;
        private System.Windows.Forms.TextBox tbResult;
    }
}

