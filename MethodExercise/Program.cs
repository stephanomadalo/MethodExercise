using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Message("name");
            string animal = Message("favorite animal");
            string band = Message("favorite band");
            string color = Message("favorite color");

            DisplayOutput(name, animal, band, color);

            int k;
            Program p1 = new Program();
            k = p1.Add(10, 10, 10, 4, 4);
            Console.WriteLine("(param) the result is: "+ k);
            k = p1.Add(1, 10, 11, 40, 4);
            Console.WriteLine("(param) the result is: "+ k);

            Sum(4, 8);
            Subtract(7, 6);
            Multiply(8, 6);
            Divide(9, 6);
            Modulus(9, 6);

        }



        public static string Message(string msg)
        {
            Console.WriteLine("What is your {0}?", msg);
            return Console.ReadLine();
        }

        public static void DisplayOutput(string name, string animal, string band, string color)
        {
            Console.WriteLine($"Your name is {name}? ewwww haha, your favorite animals are {animal}? that's pretty cool at least :) " +
                $"I am also really fond of the color {color} and {band} kicks ass");

        }
        int Add(params int[] arr1)
        {
            int i, s = 0;
            for(i=0;i<arr1.Length;i++)
            {
                s = s + arr1[i];
            }
            return s;

        }
        static void Sum(int num1, int num2) 
        {
            int result = num1 + num2;
            Console.WriteLine("the result is: "+ result);
        }

        static void Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("the result is: " + result);
        }

        static void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("the result is: " + result);
        }

        static void Divide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine("the result is: " + result);
        }

        static void Modulus(int num1, int num2)
        {
            int result = num1 % num2;
            Console.WriteLine("the result is: " + result);
        }
    }
}
