using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS_11
{
    class Generator
    {
        double[] stats = new double[5];
        public double[] freq = new double[5];
        public double[] ps = new double[5];
        public static int N;
        Random rnd = new Random();
        double alpha;
        void generateEvent()
        {
            alpha = rnd.NextDouble();
            for (int i = 0; i < 5; i++)
            {
                alpha -= ps[i];
                if (alpha < 0)
                {
                    stats[i]++;
                    break;
                }
            }
        }

        public void createExperiments()
        {
            for (int i = 0; i < N; i++)
            {
                generateEvent();
            }
            for (int i = 0; i < 5; i++)
            {
                freq[i] = stats[i] / N;
            }
        }

        public bool isNorm()
        {
            double p = 0;
            foreach (var pr in ps)
            {
                p += pr;
            }
            if (p == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Mean()
        {
            double mean = 0;
            for (int i = 0; i < 5; i++)
            {
                mean += i+1 * ps[i];
            }
            return mean;
        }

        public double Vari()
        {
            double vari = 0;
            double mean = Mean();
            for (int i = 0; i < 5; i++)
            {
                vari += ps[i] * (i+1) * (i+1);
            }
            vari -= mean * mean;
            return vari;
        }

        public double EmpiricMean()
        {
            double mean = 0;
            for (int i = 0; i < 5; i++)
            {
                mean += freq[i] * (i+1);
            }
            return mean;
        }

        public double EmpiricVari()
        {
            double vari = 0;
            double mean = EmpiricMean();
            for (int i = 0; i < 5; i++)
            {
                vari += freq[i] * (i+1) * (i+1);
            }
            vari -= mean * mean;
            return vari;
        }

        public double meanError()
        {
            double error = 0;
            double empiricMean = EmpiricMean();
            double mean = Mean();

            error = Math.Abs((empiricMean - mean) / mean);

            return error;
        }

        public double variError()
        {
            double error = 0;
            double empiricVari = EmpiricVari();
            double vari = Vari();

            error = Math.Abs((empiricVari - vari) / vari);

            return error;
        }

        public double ChiSquared()
        {
            double chiSquared = 0;

            for (int i = 0; i < 5; i++)
            {
                chiSquared += ((stats[i] * stats[i]) / (N * ps[i]));
            }
            chiSquared -= N;
            return chiSquared;
        }

        public bool isTrue()
        {
            double empiricChi = ChiSquared();
            double tableChi = 9.488f;
            if (empiricChi > tableChi)
                return true;
            else
                return false;
        }
    }
}
