
using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenFibonnacci
{
    class Program
    {
        //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 2;
            int sum = 0;

            List<int> evens = new List<int>();

            do
            {
                if(number1 % 2 == 0 && !evens.Contains(number1)) evens.Add(number1);
                if(number2 % 2 == 0 && !evens.Contains(number2)) evens.Add(number2);

                sum = number1 + number2;

                Console.WriteLine(number1 + " + " + number2 + " = " + sum);

                number1 = number2;
                number2 = sum;

            } while (sum < 4000000);

            
            Console.WriteLine(evens.Sum());

            Console.ReadLine();
        }
    }
}
