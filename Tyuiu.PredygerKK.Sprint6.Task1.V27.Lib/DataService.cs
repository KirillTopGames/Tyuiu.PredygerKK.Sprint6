using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PredygerKK.Sprint6.Task1.V27.Lib
{
    public class DataService : ISprint6Task1V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int cnt = 0;
            double y;
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 1)
                {
                    res[cnt] = 0;
                }
                else
                {
                    y = Math.Round(4 - 2*x + (2 + Math.Cos(x)) / (2*x - 2), 2);


                    res[cnt] = y;
                }
                cnt++;
            }
            return res;
        }
    }
}