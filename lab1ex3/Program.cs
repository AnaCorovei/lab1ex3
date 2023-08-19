using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex3
            Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura*/

            int intNumber;

            Console.WriteLine("Write the number: ");
            intNumber = int.Parse(Console.ReadLine());

            int lastDigitNumber = intNumber % (10);
            Console.WriteLine("The last digit of your number is " +  lastDigitNumber);
        }
    }
}
