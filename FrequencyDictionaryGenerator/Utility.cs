using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyDictionaryGenerator
{
    internal static class Utility
    {
        public static void GetFrequancy(string incoming_file_path, string result_file_path)
        {

            StreamReader inputFile;
            string words = string.Empty;
            try
            {
                if (File.Exists(incoming_file_path))
                {
                    inputFile = new StreamReader(incoming_file_path);
                    words = inputFile.ReadLine();
                }

                var dict = new Dictionary<string, int>();
                foreach (var word in words.Split(' '))
                {
                    if (dict.ContainsKey(word))
                        dict[word]++;
                    else
                        dict.Add(word, 1);

                }
                foreach (var e in dict)
                {
                    Console.WriteLine($"{e.Key}){e.Value}");
                    File.WriteAllLines(result_file_path,
                   dict.Select(x => "[" + x.Key + " " + x.Value + "]").ToArray());

                }

            }
            catch (Exception ex)
            {
                throw ex;

            }


        }
    }
}
