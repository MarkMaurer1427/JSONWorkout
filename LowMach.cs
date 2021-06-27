using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JSONWorkout
{
    static class LowMach
    {
        static JObject obj = JObject.Parse(File.ReadAllText(@"LowerMachine.json"));
        static JToken exercises = obj["Lower Body Machine Set"];

        static MachineEx low1 = new MachineEx(exercises[0]);
        static MachineEx low2 = new MachineEx(exercises[1]);

        public static MachineEx GetEx(int id)
        {
            switch (id)
            {
                case 0: return low1;
                case 1: return low2;
                default: return low1;
            }
        }
    }
}
