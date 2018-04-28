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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // func1
            // 
            this.func1.Location = new System.Drawing.Point(95, 12);
            this.func1.Name = "func1";
            this.func1.Size = new System.Drawing.Size(100, 20);
            this.func1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Funkcja celu 1";
            // 
            // func2
            // 
            this.func2.Location = new System.Drawing.Point(95, 39);
            this.func2.Name = "func2";
            this.func2.Size = new System.Drawing.Size(100, 20);
            this.func2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Funkcja celu 2";
            // 
            // popSize
            // 
            this.popSize.Location = new System.Drawing.Point(95, 66);
            this.popSize.Name = "popSize";
            this.popSize.Size = new System.Drawing.Size(100, 20);
            this.popSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rozmiar populacji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ilość iteracji";
            // 
            // iterations
            // 
            this.iterations.Location = new System.Drawing.Point(95, 92);
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(100, 20);
            this.iterations.TabIndex = 7;
            this.iterations.Text = "Ilość iteracji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pb krzyżowania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pb mutacji";
            // 
            // crossingPb
            // 
            this.crossingPb.Location = new System.Drawing.Point(95, 118);
            this.crossingPb.Name = "crossingPb";
            this.crossingPb.Size = new System.Drawing.Size(100, 20);
            this.crossingPb.TabIndex = 11;
            // 
            // mutationPb
            // 
            this.mutationPb.Location = new System.Drawing.Point(95, 144);
            this.mutationPb.Name = "mutationPb";
            this.mutationPb.Size = new System.Drawing.Size(100, 20);
            this.mutationPb.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

