using System;
using System.Collections.Generic;
using System.Text;

namespace JSONWorkout
{
    class WorkoutGen
    {
        static Random rand = new Random();

        public static int GetReps(int num)
        {
            switch (num)
            {
                case 0: return 6;
                case 1: return 8;
                case 2: return 10;
                case 3: return 12;
                default: return 0;
            }
        }

        public static string GetCardio(int num)
        {
            switch (num)
            {
                case 0: return "Treadmill";
                case 1: return "Bike";
                case 2: return "Elliptical";
                default: return "This isn't supposed to happen";
            }
        }

        public static void GetUpper()
        {
            int[] nums = new int[6];
            //[0]: Machine 1
            //[1]: Machine 2
            //[2]: Free
            //[3]: Core
            //[4]: Cardio
            //[5]: Reps
            nums[0] = rand.Next(4);
            //Ensure that the same machine set won't be picked twice.
            do
            {
                nums[1] = rand.Next(4);
            }
            while (nums[1] == nums[0]);

            nums[2] = rand.Next(4);
            nums[3] = rand.Next(5);
            nums[4] = rand.Next(3);
            nums[5] = rand.Next(4);

            Console.WriteLine("Upper Body Workout");
            Console.WriteLine($"2 sets, {GetReps(nums[5])} reps each");
            Console.WriteLine();
            var ex1 = UpMach.GetEx(nums[0]);
            Console.WriteLine($"{ex1.flexor}: {ex1.weights[nums[5]]} lbs.");
            Console.WriteLine($"{ex1.extensor}: {ex1.weights[nums[5]]} lbs.");
            var ex2 = UpMach.GetEx(nums[1]);
            Console.WriteLine($"{ex2.flexor}: {ex2.weights[nums[5]]} lbs.");
            Console.WriteLine($"{ex2.extensor}: {ex2.weights[nums[5]]} lbs.");
            var ex3 = UpFree.GetEx(nums[2]);
            Console.WriteLine($"{ex3.name}: {ex3.weights[nums[5]]} lbs.");
            var ex4 = CoreSet.GetEx(nums[3]);
            Console.WriteLine($"{ex4.name}: {ex4.weight} lbs. (20 reps)");
            Console.WriteLine();
            Console.WriteLine($"Cardio exercise: {GetCardio(nums[4])}, 30 minutes.");




        }

        public static void GetLower()
        {
            int[] nums = new int[6];
            //[0] Machine
            //[1] Free set 1
            //[2] Free set 2
            //[3] Core
            //[4] Cardio
            //[5] Reps
            nums[0] = rand.Next(2);
            nums[1] = rand.Next(5);
            do
            {
                nums[2] = rand.Next(5);
            }
            while (nums[2] == nums[1]);
            nums[3] = rand.Next(5);
            nums[4] = rand.Next(3);
            nums[5] = rand.Next(4);
            Console.WriteLine("Lower Body Workout");
            Console.WriteLine($"2 sets, {GetReps(nums[5])} reps each");
            Console.WriteLine();
            var ex1 = LowMach.GetEx(nums[0]);
            Console.WriteLine($"{ex1.flexor}: {ex1.weights[nums[5]]} lbs.");
            Console.WriteLine($"{ex1.extensor}: {ex1.weights[nums[5]]} lbs.");
            var ex2 = LowFree.GetEx(nums[1]);
            Console.WriteLine($"{ex2.name}: {ex2.weights[nums[5]]} lbs.");
            var ex3 = LowFree.GetEx(nums[2]);
            Console.WriteLine($"{ex3.name}: {ex3.weights[nums[5]]} lbs.");
            var ex4 = CoreSet.GetEx(nums[3]);
            Console.WriteLine($"{ex4.name}: {ex4.weight} lbs. (20 reps)");
            Console.WriteLine();
            Console.WriteLine($"Cardio exercise: {GetCardio(nums[4])}, 30 minutes.");
        }

        public static void GetCombo()
        {
            int[] nums = new int[7];
            //[0] Upper Machine
            //[1] Lower Machine
            //[2] Upper Free
            //[3] Lower Free
            //[4] Core
            //[5] Cardio
            //[6] Reps
            nums[0] = rand.Next(4);
            nums[1] = rand.Next(2);
            nums[2] = rand.Next(4);
            nums[3] = rand.Next(5);
            nums[4] = rand.Next(5);
            nums[5] = rand.Next(3);
            nums[6] = rand.Next(4);

            Console.WriteLine("Combination Workout");
            Console.WriteLine($"2 sets, {GetReps(nums[5])} reps each");
            Console.WriteLine();
            var ex1 = UpMach.GetEx(nums[0]);
            Console.WriteLine($"{ex1.flexor}: {ex1.weights[nums[6]]} lbs.");
            Console.WriteLine($"{ex1.extensor}: {ex1.weights[nums[6]]} lbs.");
            var ex2 = LowMach.GetEx(nums[1]);
            Console.WriteLine($"{ex2.flexor}: {ex2.weights[nums[6]]} lbs.");
            Console.WriteLine($"{ex2.extensor}: {ex2.weights[nums[6]]} lbs.");
            var ex3 = UpFree.GetEx(nums[2]);
            Console.WriteLine($"{ex3.name}: {ex3.weights[nums[6]]} lbs.");
            var ex4 = LowFree.GetEx(nums[3]);
            Console.WriteLine($"{ex4.name}: {ex4.weights[nums[6]]} lbs.");
            var ex5 = CoreSet.GetEx(nums[4]);
            Console.WriteLine($"{ex5.name}: {ex5.weight} lbs. (20 reps)");
            Console.WriteLine();
            Console.WriteLine($"Cardio exercise: {GetCardio(nums[5])}, 30 minutes.");
        }

    }
}
