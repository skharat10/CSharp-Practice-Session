using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class Anagram //Two words are said to be Anagrams of each other if they share the same set of letters to form the respective words.for an example: Silent–>Listen, post–>opts.
    {
        static void Main(string[] args)
        {
            // take words from user
            Console.WriteLine("Enter the first word: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter the second one: ");
            string word2 = Console.ReadLine();

            // add optional validation of input words if needed.....
            //..........

            //step1
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            //step2
            Array.Sort(char1);
            Array.Sort(char2);

            //step3
            string newWord1 = new string(char1);
            string newWord2 = new string(char2);

            //step4
            //ToLower allows to compare the words in the same case, in this case, lower case.
            //ToUpper will also do the exact same thing in this context.
            if(newWord1 == newWord2)
            {
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("No! words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
            }

            
        }


    }
}
