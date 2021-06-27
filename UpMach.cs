using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JSONWorkout
{
    static class UpMach
    {
        static JObject obj = JObject.Parse(File.ReadAllText(@"UpperMachine.json"));
        static JToken exercises = obj["Upper Body Machine Set"];

        static MachineEx up1 = new MachineEx(exercises[0]);
        static MachineEx up2 = new MachineEx(exercises[1]);
        static MachineEx up3 = new MachineEx(exercises[2]);
        static MachineEx up4 = new MachineEx(exercises[3]);


        public static MachineEx GetEx(int id)
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
