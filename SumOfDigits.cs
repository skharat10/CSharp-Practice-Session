using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class SumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0; //sum- used to store the running sumofdigits
            int temp = number; //temp- variable copy of the input number that we will modify during the loop
            int remainder;

            while(temp != 0)
            {
                remainder = temp % 10; // gives the rightmost digit of the number
                sum = sum + remainder; // we add this digit to the sum variable
                temp = temp / 10;      // then divide temp by 10 to remove the rightmost digit
            }
            Console.WriteLine("The sum of the digits of {0} is {1}.", number, sum);
            Console.ReadLine();
        }
    }
}
