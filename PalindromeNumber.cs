using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class PalindromeNumber
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter the number to check it is palindrome or not: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while(n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;

            }
            if (temp == sum)
                Console.WriteLine("Number is palindrome");
            else
                Console.WriteLine("Number is not palindrome");
            
        }
    }
}
