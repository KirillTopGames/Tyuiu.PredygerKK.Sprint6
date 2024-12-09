using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PredygerKK.Sprint6.Task6.V13.Lib
{
    public class DataService : ISprint6Task6V13
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
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
            }
            return res;
        }
    }
}
