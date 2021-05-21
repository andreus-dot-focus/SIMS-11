using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_11
{
    public partial class Form1 : Form
    {
        Generator gen = new Generator();
        public Form1()
        {
            InitializeComponent();
            gen.ps[0] = Convert.ToDouble(p1TB.Text);
            gen.ps[1] = Convert.ToDouble(p2TB.Text);
            gen.ps[2] = Convert.ToDouble(p3TB.Text);
            gen.ps[3] = Convert.ToDouble(p4TB.Text);
            gen.ps[4] = Convert.ToDouble(p5TB.Text);
        }

        private void p1TB_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("hpl");
            if (p1TB.TextLength > 0)
            {
                try
                {
                    gen.ps[0] = Convert.ToDouble(p1TB.Text);
                    if (gen.ps[0] < 0)
                    {
                        p1TB.Text = "0";
                        gen.ps[0] = 0;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный ввод!");
                }
                double sum = 0;
                for (int i = 0; i < 4; i++)
                {
                    sum += gen.ps[i];
                }
                double p5 = 1 - sum;
                if (p5 < 0)
                    p5 = 0;
                gen.ps[4] = p5;
                p5TB.Text = p5.ToString();
            }
        }

        private void p2TB_Leave(object sender, EventArgs e)
        {
            if (p2TB.TextLength > 0)
            {
                try
                {
                    gen.ps[1] = Convert.ToDouble(p2TB.Text);
                    if (gen.ps[1] < 0)
                    {
                        p2TB.Text = "0";
                        gen.ps[1] = 0;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный ввод!");
                }
                double sum = 0;
                for (int i = 0; i < 4; i++)
                {
                    sum += gen.ps[i];
                }
                double p5 = 1 - sum;
                if (p5 < 0)
                    p5 = 0;
                gen.ps[4] = p5;
                p5TB.Text = p5.ToString();
            }
        }

        private void p3TB_Leave(object sender, EventArgs e)
        {
            if (p3TB.TextLength > 0)
            {
                try
                {
                    gen.ps[2] = Convert.ToDouble(p3TB.Text);
                    if (gen.ps[2] < 0)
                    {
                        p3TB.Text = "0";
                        gen.ps[2] = 0;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный ввод!");
                }
                double sum = 0;
                for (int i = 0; i < 4; i++)
                {
                    sum += gen.ps[i];
                }
                double p5 = 1 - sum;
                if (p5 < 0)
                    p5 = 0;
                gen.ps[4] = p5;
                p5TB.Text = p5.ToString();
            }
        }

        private void p4TB_Leave(object sender, EventArgs e)
        {
            if (p4TB.TextLength > 0)
            {
                try
                {
                    gen.ps[3] = Convert.ToDouble(p4TB.Text);
                    if (gen.ps[3] < 0)
                    {
                        p4TB.Text = "0";
                        gen.ps[3] = 0;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный ввод!");
                }
                double sum = 0;
                for (int i = 0; i < 4; i++)
                {
                    sum += gen.ps[i];
                }
                double p5 = 1 - sum;
                if (p5 < 0)
                    p5 = 0;
                gen.ps[4] = p5;
                p5TB.Text = p5.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            if (nTB.TextLength > 0)
            {
                Generator.N = Convert.ToInt32(nTB.Text);
            }
            if (gen.isNorm())
            {
                gen.createExperiments();
                for (int i = 0; i < 5; i++)
                {
                    chart1.Series[0].Points.AddXY(i + 1, gen.freq[i]);
                }
                meanLabel.Text = meanLabel.Text + gen.EmpiricMean().ToString() + "(error: " + gen.meanError().ToString() + ")";
                variLabel.Text = variLabel.Text + gen.EmpiricVari().ToString() + "(error: " + gen.variError().ToString() + ")";
                chiLabel.Text = chiLabel.Text + gen.ChiSquared().ToString() + " > " + "9.488 is " + gen.isTrue().ToString();
            }
            else
            {
                MessageBox.Show("Не выполняется условие нормировки!");
            }
        }
    }
}

