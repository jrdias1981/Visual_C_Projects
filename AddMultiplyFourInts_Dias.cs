//Software Development C#
//Jonathas Dias
//2-2 Module - Adding and Multiplying Four Integers

using System; 

namespace AddMultiplyFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int num1 = 13, num2 = 55, num3 = 123, num4 = 325, Sum, Product;

            //Sum of given integers

            Sum = num1 + num2 + num3 + num4;
            //Multiplication of given integers

            Product = num1 * num2 * num3 * num4;

            //Display the output

            Console.WriteLine("Jonathas Dias Copy");
            Console.WriteLine($"The sum of {num1}, {num2}, {num3}, {num4} = {Sum}.");
            Console.WriteLine($"The product of {num1}, {num2}, {num3}, {num4} = {Product}.");

            Console.ReadKey();
        }
    }
}

