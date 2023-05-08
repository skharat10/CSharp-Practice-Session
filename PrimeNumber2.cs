using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class PrimeNumber2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true; //used to keep track of whether the number is prime or not

            for(int i = 2; i*i < number; i++) 
            {
                if(number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime && number > 1)

                Console.WriteLine("{0} is a prime number.", number);
            else
                Console.WriteLine("{0} is not a prime number. ", number);

            Console.ReadLine();
        }
    }
}
