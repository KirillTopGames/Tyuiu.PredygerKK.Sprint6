using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PredygerKK.Sprint6.Task5.V12.Lib
{
    public class DataService : ISprint6Task5V12
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] TempArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    TempArray[index] = Math.Round(Convert.ToDouble(line), 3);
                    index++;
                }
            }

            TempArray = TempArray.Where(value => value % 5 != 0).ToArray();

            return TempArray;
        }
    }
}
