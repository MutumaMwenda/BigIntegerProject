using Excercise01;
using System;

namespace Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Hello There---");

            string Number = "";

            Console.WriteLine("Enter your number: ");
            Number = Console.ReadLine().ToString();

            //Converting to words
            Console.WriteLine("Your number in words: \n"+ Excercise.Towards(Convert.ToInt32(Number)));
            Console.ReadLine();
        }
    }
}
