using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DudkovIE.Sprint6.Task0.V30.Lib
{
    public class DataService : ISprint6Task0V30
    {
        public double Calculate(int x)
        {
            double y = x * Math.Sqrt(x + 3);
            return Math.Round(y, 3);
        }
    }
}
