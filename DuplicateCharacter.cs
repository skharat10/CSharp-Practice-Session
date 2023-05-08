using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class DuplicateCharacter
    {
        static void Main(string[] args)
        {
            string value1 = RemoveDuplicateChars("Google");
            Console.WriteLine(value1);

            string value2 = RemoveDuplicateChars("google");
            Console.WriteLine(value2);
        }

        static string RemoveDuplicateChars(string key)
        {
            // --- Removes duplicate chars using string concats. ---
            // store encountered letter in this string.
            string table = " ";

            // store the result in this string
            string result = " ";

            // loop over to each char
            foreach (char value in key)
            {
                // see if char is in the table
                if(table.IndexOf(value) == -1)
                {
                    // append to the table and the result.
                    table = table + value;
                    result = result + value;
                }
            }
            return result;

        }
    }
}
