using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PredygerKK.Sprint6.Task7.V8.Lib
{
    public class DataService : ISprint6Task7V8
    {
        public int[,] GetMatrix(string path)
        {
            string[] file = File.ReadAllLines(path);

            int columns = file[0].Split(";").Length;
            int rows = file.Length;

            int[,] matrix = new int[columns, rows];

            for (int i = 0; i < file.Length; i++)
            {
                string[] digits = file[i].Split(";");
                for (int j = 0; j < digits.Length; j++)
                {
                    int digit = Convert.ToInt32(digits[j]);
                    if (j == 7 && digit != 5)
                    {
                        matrix[i, j] = -1;
                    }
                    else
                    {
                        matrix[i, j] = digit;
                    }
                }
            }
            return matrix;
        }
    }
}
