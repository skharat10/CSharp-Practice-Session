using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class ArmstrongNumber //Armstrong number is a number that is equal to the sum of cubes of its digits. For example 0, 1, 153, 370, 371 and 407 are the Armstrong numbers.
    {
        static void Main(string[] args)
        {
            int r, n, sum = 0, temp;
            Console.WriteLine("Enter any number");
            n = int.Parse(Console.ReadLine());
            temp = n;

            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not Armstrong number");
            }
        }
        


    }
}
