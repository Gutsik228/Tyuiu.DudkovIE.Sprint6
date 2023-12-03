using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DudkovIE.Sprint6.Task1.V20.Lib
{
    public class DataService : ISprint6Task1V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] arr;
            int len = (stopValue - startValue) + 1;
            arr = new double[len];
            double y = 0;
            int count = 0;
            for(int x = startValue; x <= stopValue; x++)
            {
                if((Math.Cos(x) - 2 * x) == 0)
                {
                    arr[count] = 0;
                    continue;
                    count++;
                }
                else
                {
                    y = ((2 * x) / (Math.Cos(x) - 2 * x)) + 5 * x - Math.Sin(x);

                    arr[count] = y;
                    count++;
                }
            }
            return arr;
        }
    }
}
