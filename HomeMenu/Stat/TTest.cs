///author Arif Khan, first made on 8 March, 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeMenu.Stat//Attn: Check the Namespace before importing into different projects.
{
    public class TTest
    {
        private double[] x,y;        
        public double meanX, meanY,tVal,degreeOfFreedom,pVal;
        public TTest(double[] x, double[] y)
        {
            this.x = x;
            this.y = y;
            double sumX = 0.0;
            double sumY = 0.0;
            for (int i = 0; i < this.x.Length; ++i)
                sumX += this.x[i];
            for (int i = 0; i < this.y.Length; ++i)
                sumY += this.y[i];
            int n1 = this.x.Length;
            int n2 = this.y.Length;
            meanX = sumX / n1;
            meanY = sumY / n2;
            double sumXminusMeanSquared = 0.0; // Calculate variances
            double sumYminusMeanSquared = 0.0;
            for (int i = 0; i < n1; ++i)
                sumXminusMeanSquared += (this.x[i] - meanX) * (this.x[i] - meanX);
            for (int i = 0; i < n2; ++i)
                sumYminusMeanSquared += (this.y[i] - meanY) * (this.y[i] - meanY);
            double varX = sumXminusMeanSquared / (n1 - 1);
            double varY = sumYminusMeanSquared / (n2 - 1);
            double top = (meanX - meanY);
            double bot = Math.Sqrt((varX / n1) + (varY / n2));
            tVal = top / bot;
            double num = ((varX / n1) + (varY / n2)) *
  ((varX / n1) + (varY / n2));
            double denomLeft = ((varX / n1) * (varX / n1)) / (n1 - 1);
            double denomRight = ((varY / n2) * (varY / n2)) / (n2 - 1);
            double denom = denomLeft + denomRight;
            degreeOfFreedom = num / denom;
            pVal = Student(tVal, degreeOfFreedom); // Cumulative two-tail density
            
            
        }
        public string getResultString()
        {
            string s = "";
            s+="mean of x = " + meanX.ToString("F2");
            s+="\nmean of y = " + meanY.ToString("F2");
            s+="\nt-value is  = " + tVal.ToString("F4");
            s+="\ndegreeOfFreedom = " + degreeOfFreedom.ToString("F3");
            s += "\np-value = " + pVal.ToString("F5");
            s += "\n\n"+@"===========================If the p-value 
is low, typically less than 0.05 or 0.01, then you conclude there is 
statistical evidence the two means are different. But if the p-value 
isn't below the 5%or 1% critical value then you conclude there\'s not 
enough evidence to say the means are different.
=============================="+"\n\n";
            return s;
        }
        /// <summary>
        /// Calculates the Area under the Standard Normal Distribution
        /// </summary>
        /// <param name="z"></param>
        /// <returns></returns>
        private double Gauss(double z)
        {
          // input = z-value (-inf to +inf)
          // output = pVal under Standard Normal curve from -inf to z
          // e.g., if z = 0.0, function returns 0.5000
          // ACM Algorithm #209
          double y; // 209 scratch variable
          double p; // result. called 'z' in 209
          double w; // 209 scratch variable
          if (z == 0.0)
            p = 0.0;
          else
          {
            y = Math.Abs(z) / 2;
            if (y >= 3.0)
            {
              p = 1.0;
            }
            else if (y < 1.0)
            {
              w = y * y;
              p = ((((((((0.000124818987 * w
                - 0.001075204047) * w + 0.005198775019) * w
                - 0.019198292004) * w + 0.059054035642) * w
                - 0.151968751364) * w + 0.319152932694) * w
                - 0.531923007300) * w + 0.797884560593) * y * 2.0;
            }
            else
            {
              y = y - 2.0;
              p = (((((((((((((-0.000045255659 * y
                + 0.000152529290) * y - 0.000019538132) * y
                - 0.000676904986) * y + 0.001390604284) * y
                - 0.000794620820) * y - 0.002034254874) * y
                + 0.006549791214) * y - 0.010557625006) * y
                + 0.011630447319) * y - 0.009279453341) * y
                + 0.005353579108) * y - 0.002141268741) * y
                + 0.000535310849) * y + 0.999936657524;
            }
          }
          if (z > 0.0)
            return (p + 1.0) / 2;
          else
            return (1.0 - p) / 2;
        }//end method
        
        /// <summary>
        /// Calculates the Area under the tVal-Distribution
        /// </summary>
        /// <param name="tVal"></param>
        /// <param name="degreeOfFreedom"></param>
        /// <returns></returns>
        private double Student(double t, double df)
        {
          // for large integer degreeOfFreedom or double degreeOfFreedom
          // adapted from ACM algorithm 395
          // returns 2-tail pVal-value
          double n = df; // to sync with ACM parameter name
          double a, b, y;
          t = t * t;
          y = t / n;
          b = y + 1.0;
          if (y > 1.0E-6) y = Math.Log(b);
          a = n - 0.5;
          b = 48.0 * a * a;
          y = a * y;
          y = (((((-0.4 * y - 3.3) * y - 24.0) * y - 85.5) /
            (0.8 * y * y + 100.0 + b) + y + 3.0) / b + 1.0) *
            Math.Sqrt(y);
          return 2.0 * Gauss(-y); // ACM algorithm 209
        }
    }//end class
}//end namespace
