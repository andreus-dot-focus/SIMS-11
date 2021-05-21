
namespace SIMS_11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p5TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.p4TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.p3TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.p2TB = new System.Windows.Forms.TextBox();
            this.p1TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chiLabel = new System.Windows.Forms.Label();
            this.variLabel = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.p5TB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.p4TB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.p3TB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.p2TB);
            this.panel1.Controls.Add(this.p1TB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 495);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(106, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nTB
            // 
            this.nTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nTB.Location = new System.Drawing.Point(178, 362);
            this.nTB.Name = "nTB";
            this.nTB.Size = new System.Drawing.Size(105, 22);
            this.nTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(125, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "N";
            // 
            // p5TB
            // 
            this.p5TB.Enabled = false;
            this.p5TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p5TB.Location = new System.Drawing.Point(178, 272);
            this.p5TB.Name = "p5TB";
            this.p5TB.Size = new System.Drawing.Size(105, 22);
            this.p5TB.TabIndex = 9;
            this.p5TB.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(90, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prob 5";
            // 
            // p4TB
            // 
            this.p4TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p4TB.Location = new System.Drawing.Point(178, 220);
            this.p4TB.Name = "p4TB";
            this.p4TB.Size = new System.Drawing.Size(105, 22);
            this.p4TB.TabIndex = 7;
            this.p4TB.Text = "0";
            this.p4TB.Leave += new System.EventHandler(this.p4TB_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(90, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prob 4";
            // 
            // p3TB
            // 
            this.p3TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p3TB.Location = new System.Drawing.Point(178, 166);
            this.p3TB.Name = "p3TB";
            this.p3TB.Size = new System.Drawing.Size(105, 22);
            this.p3TB.TabIndex = 5;
            this.p3TB.Text = "0";
            this.p3TB.Leave += new System.EventHandler(this.p3TB_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(90, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prob 3";
            // 
            // p2TB
            // 
            this.p2TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p2TB.Location = new System.Drawing.Point(178, 113);
            this.p2TB.Name = "p2TB";
            this.p2TB.Size = new System.Drawing.Size(105, 22);
            this.p2TB.TabIndex = 3;
            this.p2TB.Text = "0";
            this.p2TB.Leave += new System.EventHandler(this.p2TB_Leave);
            // 
            // p1TB
            // 
            this.p1TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p1TB.Location = new System.Drawing.Point(178, 62);
            this.p1TB.Name = "p1TB";
            this.p1TB.Size = new System.Drawing.Size(105, 22);
            this.p1TB.TabIndex = 2;
            this.p1TB.Text = "0";
            this.p1TB.Leave += new System.EventHandler(this.p1TB_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prob 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prob 1";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(453, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(811, 342);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chiLabel);
            this.panel2.Controls.Add(this.variLabel);
            this.panel2.Controls.Add(this.meanLabel);
            this.panel2.Location = new System.Drawing.Point(453, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 135);
            this.panel2.TabIndex = 3;
            // 
            // chiLabel
            // 
            this.chiLabel.AutoSize = true;
            this.chiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chiLabel.Location = new System.Drawing.Point(92, 105);
            this.chiLabel.Name = "chiLabel";
            this.chiLabel.Size = new System.Drawing.Size(102, 20);
            this.chiLabel.TabIndex = 2;
            this.chiLabel.Text = "Chi-Squared:";
            // 
            // variLabel
            // 
            this.variLabel.AutoSize = true;
            this.variLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.variLabel.Location = new System.Drawing.Point(38, 56);
            this.variLabel.Name = "variLabel";
            this.variLabel.Size = new System.Drawing.Size(71, 20);
            this.variLabel.TabIndex = 1;
            this.variLabel.Text = "Variable:";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.meanLabel.Location = new System.Drawing.Point(38, 25);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(72, 20);
            this.meanLabel.TabIndex = 0;
            this.meanLabel.Text = "Average:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p5TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p4TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p3TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p2TB;
        private System.Windows.Forms.TextBox p1TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label variLabel;
        private System.Windows.Forms.Label chiLabel;
    }
}

