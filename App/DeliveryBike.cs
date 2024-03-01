using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class DeliveryBike
    {
        public int Count(int[] packageWeights, int groupWeight)
        {
            Dictionary<int, int> weightFrequency = new Dictionary<int, int>();
            foreach (int weight in packageWeights)
            {
                if (weightFrequency.ContainsKey(weight))
                {
                    weightFrequency[weight]++;
                }
                else
                {
                    weightFrequency[weight] = 1;
                }
            }

            int totalBikes = 0;
            foreach (int weight in packageWeights)
            {
                int complement = groupWeight - weight;
                if (weightFrequency.ContainsKey(complement) && weightFrequency[complement] > 0)
                {
                    totalBikes++;
                    weightFrequency[weight]--;
                    weightFrequency[complement]--;
                }
            }
            return totalBikes;
        }
    }
}
