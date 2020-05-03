using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeMenu.DataMining
{
    public class BasicDBMining
    {
        /// <summary>
        /// Assumes that higher (or equal) to calculated score compared to threshold will give higher trueScore 
        /// calculatedScore and true Score, both are of the same size
        /// </summary>
        /// <param name="calculatedScore"></param>
        /// <param name="trueScore"></param>
        /// <param name="stepSize"></param>
        /// <returns></returns>
        public static OptimumBinClassRetType CalculateOptimumBinClassificationAndAccuracy (List<double> calculatedScore, List<int> trueScore, double stepSize)
        {
            OptimumBinClassRetType optimumBinClassRetType = new OptimumBinClassRetType(Double.MinValue,0.0);
            double min = (from c in calculatedScore select c).Min();
            double max = (from c in calculatedScore select c).Max();
            int hit, maxHit = int.MinValue;
            for (double d = min; d <= max; d += stepSize)
            {
                hit = 0;
                for (int i = 0; i < calculatedScore.Count; i++)//traverse all calculatedScore elements. It might not be sorted
                {
                    if (calculatedScore[i] >= d)
                        hit += trueScore[i] == 1 ? 1 : 0;//above partition. If truescore is 1, it a hit.
                    else
                        hit += trueScore[i] == 0 ? 1 : 0;        
                }
                //compare and update if applicable
                if (hit > maxHit)
                {
                    maxHit = hit;
                    optimumBinClassRetType.optimumPoint = d;
                }
            }
            optimumBinClassRetType.accuracyPercentage = ((double)maxHit / calculatedScore.Count);
            return optimumBinClassRetType;
        }
    }
    public class OptimumBinClassRetType
    {
        public double optimumPoint = -0.0;
        public double accuracyPercentage = -0.0;
        public OptimumBinClassRetType(double optimumPoint,double accuracyPercentage)
        {
            this.optimumPoint = optimumPoint;
            this.accuracyPercentage = accuracyPercentage;
        }
        
    }

}
