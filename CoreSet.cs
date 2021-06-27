using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JSONWorkout
{
    static class CoreSet
    {
        static JObject obj = JObject.Parse(File.ReadAllText(@"CoreExercises.json"));
        static JToken exercises = obj["Core Exercises"];

        static CoreEx c1 = new CoreEx(exercises[0]);
        static CoreEx c2 = new CoreEx(exercises[1]);
        static CoreEx c3 = new CoreEx(exercises[2]);
        static CoreEx c4 = new CoreEx(exercises[3]);
        static CoreEx c5 = new CoreEx(exercises[4]);

        public static CoreEx GetEx(int id)
        {
            switch (id)
            {
                case 0: return c1;
                case 1: return c2;
                case 2: return c3;
                case 3: return c4;
                case 4: return c5;
                default: return c1;
            }
        }
    }
}
