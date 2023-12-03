using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DudkovIE.Sprint6.Task2.V1.Lib
{
    public class DataService : ISprint6Task2V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] arr;
            int len = (stopValue - startValue) + 1;
            arr = new double[len];
            double y = 0;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 - 2 * x) == 0)
                {
                    arr[count] = 0;
                    count++;
                    continue;
                }
                else
                {
                    y = Math.Cos(x) + ((Math.Sin(x)) / (2 - 2 * x)) - 4 * x ;

                    arr[count] = Math.Round(y, 2);
                    count++;
                }
            }
            return arr;
        }
    }
}
