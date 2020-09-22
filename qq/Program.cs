using System;
using System.ComponentModel.DataAnnotations;

namespace _03._Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            double oddMin = double.MaxValue;
            double evenMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMax = double.MinValue;
            for (var i = 1; i <= inputNumber; i++)
            {
                double addNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += addNumber;

                    if (evenMax < addNumber)
                    {
                        evenMax = addNumber;
                    }
                    if (evenMin > addNumber)
                    {
                        evenMin = addNumber;
                    }

                }
                else
                {
                    oddSum += addNumber;

                    if (oddMax < addNumber)
                    {
                        oddMax = addNumber;
                    }
                    if (oddMin > addNumber)
                    {
                        oddMin = addNumber;
                    }

                }

            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddSum == 0)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenSum == 0)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}