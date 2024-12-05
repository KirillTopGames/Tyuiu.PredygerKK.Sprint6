namespace _123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopValue = 5, startValue = -5;
            int cnt = 0;
            double y;
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            for (int x = -5; x <= 5; x++)
            {
                if (x == 1)
                {
                    res[cnt] = 0;
                }
                else
                {
                    y = Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2), 2);


                    res[cnt] = y;
                }
                Console.WriteLine(res[cnt]);
                cnt++;
            }
            
        }
    }
}
