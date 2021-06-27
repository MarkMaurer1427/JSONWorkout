using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace JSONWorkout
{
    class FreeEx
    {
        public string name;
        public int[] weights = new int[4];
        public FreeEx(JToken tok)
        {
            name = (string)tok["Name"];
            for (int i = 0; i < 4; i++)
            { weights[i] = (int)tok["Weights"][i]; }
        }
    }
}
