using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;

namespace JSONWorkout
{
    class MachineEx
    {
        public int id;
        public string flexor;
        public string extensor;
        public int[] weights = new int[4];
        public MachineEx(JToken tok)
        {
            id = (int)tok["ID"];
            flexor = (string)tok["Flexor Exercise"];
            extensor = (string)tok["Extensor Exercise"];
            for (int i=0; i<4; i++)
            {weights[i] = (int)tok["Weights"][i];}  
        }
    }
}
