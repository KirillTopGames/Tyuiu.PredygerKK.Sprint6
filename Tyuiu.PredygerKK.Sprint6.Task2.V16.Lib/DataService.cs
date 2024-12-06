using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PredygerKK.Sprint6.Task2.V16.Lib
{
    public class DataService : ISprint6Task2V16
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
                if (x == 0.4)
                {
                    res[cnt] = 0;
                }
                else
                {
                    y = Math.Round(Math.Cos(x) / (x - 0.4) + Math.Sin(x) * 8*x + 2, 2);
                    res[cnt] = y;
                }
                cnt++;
            }
            return res;
        }
    }
}
