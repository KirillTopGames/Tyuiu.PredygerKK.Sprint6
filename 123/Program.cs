using System.Data.Common;
using System.IO;

namespace _123
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask7V8.csv");
            using (StreamReader reader = new StreamReader(path))
            {
                int[]
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Split("\n").Length; i++)
                    {

                    }
                }
            }
        }
    }
}
