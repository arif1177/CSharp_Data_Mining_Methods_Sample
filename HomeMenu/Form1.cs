using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace HomeMenu
{
    public partial class frmHomeScreen : Form
    {
        public frmHomeScreen()
        {
            InitializeComponent();
        }

        private void btnDemoTTest_Click(object sender, EventArgs e)
        {
            txtBxOutput.AppendText("\nBegin Welch's t-test using C# demo\n");
            var x = new double[] { 88, 77, 78, 85, 90, 82, 88, 98, 90 };
            var y = new double[] { 81, 72, 67, 81, 71, 70, 82, 81 };
            txtBxOutput.AppendText("\nThe first data set (x) is:\n");
            txtBxOutput.AppendText(Utility.getArrayMemberAsString(x));
            txtBxOutput.AppendText("\nThe second data set (y) is:\n");
            txtBxOutput.AppendText(Utility.getArrayMemberAsString(y));
            txtBxOutput.AppendText("\nStarting Welch's t-test using C#\n");
            Stat.TTest ttest = new Stat.TTest(x,y);
            txtBxOutput.AppendText("\n" + ttest.getResultString());
            txtBxOutput.AppendText("\nEnd t-test demo\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double stepSize = 1.0;
            txtBxOutput.AppendText("\nBegin binary classification optimisation with step size "+stepSize+"\n");
            double [] x = new double[] {8,  7,  6,  5.5,  5.5,  5,  5,  4,  2,  1};
            int [] y = new int[] {      1,  1,  1,  0,    0,    1,  1,  0,  0,  0};
            txtBxOutput.AppendText("\nThe calculated score is:\n");
            txtBxOutput.AppendText(Utility.getArrayMemberAsString(x));
            txtBxOutput.AppendText("\nThe trueRisk/binary result is:\n");
            txtBxOutput.AppendText(Utility.getArrayMemberAsString(y));
            DataMining.OptimumBinClassRetType opbc = DataMining.BasicDBMining.CalculateOptimumBinClassificationAndAccuracy(x.ToList(), y.ToList(), stepSize);
            txtBxOutput.AppendText("\n\nThreshold " + opbc.optimumPoint + ". Accuracy: " + opbc.accuracyPercentage);
        }
    }
}
