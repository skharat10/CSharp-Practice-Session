using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class PrimeNumberExample //program not works with number 2
    {
        static void Main(string[] args)
        {
                int n,m = 0; 
                int flag = 0;
            Console.Write("Enter the number to check it is prime or not: ");
            n = int.Parse(Console.ReadLine());
           // Console.Write(n);
            m = n / 2;
            for(int i=2; i<=m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("The given number is not prime");
                    flag = 1;
                    break;
                }
                if (flag == 0)
                {
                    Console.Write("number is prime");
                }
                {

                }
            }

        }
    }
}
