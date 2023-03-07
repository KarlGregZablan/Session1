using System;

namespace SessionOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            do
            {
                var obj = new Exercises();
                Console.Clear();
                Console.WriteLine("Hello World!");
                Console.WriteLine("Select challenge:");
                Console.WriteLine("1. Exercise 1");
                Console.WriteLine("2. Exercise 2");
                Console.WriteLine("3. I wanna end this");
                Console.WriteLine("Choice: ");
                int value = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (value)
                {
                    case 1:
                        obj.ExerciseOneSolution();
                        break;
                    case 2:
                        obj.ExerciseTwoSolution();
                        break;
                    case 3:
                        end = true;
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            } while (!end);

        }
    }
}

//Write a program that asks you two numbers then display the sum of the two numbers