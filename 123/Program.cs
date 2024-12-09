using System.IO;

namespace _123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res = "";
            string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask6V13.txt");
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    if (words.Length >= 2)
                    {
                        res += words[words.Length - 2] + " ";
                    }
                }
                string res_trim = res.Trim();
                Console.WriteLine(res_trim + "!");
            }
        }
    }
}
