using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Taxi
{
    public class Taximeter
    {
        private readonly double StartingPrice = 6;
        private readonly double StartingMileage = 2;
        private readonly double LongMileage = 8;
        private readonly double CostPerKM = 0.8;
        private readonly double LongMileageCostPerKM = 0.8 * (1 + 0.5);

        public int GetCost(int distance, int waitMinute)
        {
            double cost = distance > 0 ? StartingPrice : 0;
            if (distance > StartingMileage)
                if (distance <= LongMileage)
                    cost = StartingPrice + (distance - StartingMileage) * CostPerKM;
                else
                    cost = StartingPrice + (LongMileage - StartingMileage) * CostPerKM + (distance - LongMileage) * LongMileageCostPerKM;
            cost += waitMinute * 0.25;
            return (int)Math.Round(cost, MidpointRounding.AwayFromZero);
        }
    }
}
