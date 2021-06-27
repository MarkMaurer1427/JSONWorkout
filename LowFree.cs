using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JSONWorkout
{
    static class LowFree
    {
        static JObject obj = JObject.Parse(File.ReadAllText(@"LowerFree.json"));
        static JToken exercises = obj["Lower Body Free Weights"];

        static FreeEx low1 = new FreeEx(exercises[0]);
        static FreeEx low2 = new FreeEx(exercises[1]);
        static FreeEx low3 = new FreeEx(exercises[2]);
        static FreeEx low4 = new FreeEx(exercises[3]);
        static FreeEx low5 = new FreeEx(exercises[4]);

        public static FreeEx GetEx(int id)
        {
            switch (id)
            {
                case 0: return low1;
                case 1: return low2;
                case 2: return low3;
                case 3: return low4;
                case 4: return low5;
                default: return low1;
            }
        }
    }
}
