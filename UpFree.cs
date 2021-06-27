using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JSONWorkout
{
    static class UpFree
    {
        static JObject obj = JObject.Parse(File.ReadAllText(@"UpperFree.json"));
        static JToken exercises = obj["Upper Body Free Weights"];

        static FreeEx up1 = new FreeEx(exercises[0]);
        static FreeEx up2 = new FreeEx(exercises[1]);
        static FreeEx up3 = new FreeEx(exercises[2]);
        static FreeEx up4 = new FreeEx(exercises[3]);

        public static FreeEx GetEx(int id)
        {
            switch (id)
            {
                case 0: return up1;
                case 1: return up2;
                case 2: return up3;
                case 3: return up4;
                default: return up1;
            }
        }
    }
}
