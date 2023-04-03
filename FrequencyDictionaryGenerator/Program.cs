// See https://aka.ms/new-console-template for more information



using FrequencyDictionaryGenerator;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class FrequencyGenrator
{
    public  static void Main(string[] args) 
    {
        
        Console.WriteLine("Please enter incoming file path");
        //C:\Users\jay\Desktop\TestCaseText.txt
        //C:\Users\jay\Desktop\ResultText.txt
        string incoming_file_path = Console.ReadLine();
        Console.WriteLine("Please enter result file path");       
        string result_file_path = Console.ReadLine();                
        Utility.GetFrequancy(incoming_file_path, result_file_path);
        Console.ReadKey();
        Console.ReadLine();

    }
}
