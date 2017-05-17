using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            const string EXIT = "exit";
            var myDictionary = new Dictionary<char, List<string>>();

            Console.WriteLine("Wpisuj słowa lub exit by zakończyć.");
            do
            {
                string word = Console.ReadLine();
                if (word.ToLower() == EXIT)
                {
                    break;
                }
                if (!myDictionary.ContainsKey(char.ToLower(word[0])))
                {
                    myDictionary.Add(char.ToLower(word[0]), new List<string>());
                }
                myDictionary[char.ToLower(word[0])].Add(word);
                
            } while (true);

            Console.WriteLine();

            foreach (var item in myDictionary)
            {
                Console.Write($"{item.Key}: ");
                foreach (var word in item.Value)
                {
                    Console.Write($"{word}, ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
