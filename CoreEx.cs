using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace JSONWorkout
{
    class CoreEx
    {
        public string name;
        public int weight;

        public CoreEx(JToken tok)
        {
            name = (string)tok["Name"];
            weight = (int)tok["Weight"];
        }
    }
}
