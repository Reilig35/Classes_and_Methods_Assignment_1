using System;

namespace Classes_and_Methods_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method 1 Start
            Console.WriteLine("Please type a number:\n");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Math_Operations method1 = new Math_Operations();

            int multiUser = method1.OperatorbyTwo(userInput1);

            Console.WriteLine($"{userInput1} multiplied by two = {multiUser}");
            //Method 1 End

            //Method 2 Start
            Console.WriteLine("Please type a decmal number:\n");
            string userInput2 = Console.ReadLine();
            float fltUser = float.Parse(userInput2);

            Math_Operations method2 = new Math_Operations();

            float divUser = method2.OperatorbyTwo(fltUser);

            Console.WriteLine($"{userInput2} divided by 2 = {divUser}");
            //Method 2 End

            //Method 3 Start
            Console.WriteLine("Please type a number:\n");
            string userInput3 = Console.ReadLine();

            Math_Operations method3 = new Math_Operations();
            string subString = method3.OperatorbyTwo(userInput3);

            Console.WriteLine($"{userInput3} minus 2 = {subString}");

            //Method 3 End
            

        }
    }
}
