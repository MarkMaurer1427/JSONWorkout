using System;

namespace JSONWorkout
{
    class Program
    {

        static void Main(string[] args)
        {
            int select = 0;

            Console.WriteLine("Welcome to Mark's Workout Generator");
            Console.WriteLine("1: Upper Body Workout");
            Console.WriteLine("2: Lower Body Workout");
            Console.WriteLine("3: Combination Workout");
            Console.WriteLine();
            do
            {
                Console.Write("Enter selection: ");
                string input = Console.ReadLine();
                if (input == "1" || input == "2" || input == "3") select = int.Parse(input);
                else Console.WriteLine("Wrong input.");
            }
            while (select == 0);

            switch (select)
            {
                case 1: { Console.WriteLine(); WorkoutGen.GetUpper(); break; }
                case 2: { Console.WriteLine(); WorkoutGen.GetLower(); break; }
                case 3: { Console.WriteLine(); WorkoutGen.GetCombo(); break; }
                default: {Console.WriteLine("This wasn't supposed to happen."); break; }
            }

        }

    }
}
