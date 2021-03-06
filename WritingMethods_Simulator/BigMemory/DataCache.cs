using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMethods_Simulator.BigMemory
{
    class DataCache
    {
        public static int sizeDC;
        public struct DataStruct
        {
            public int data;
            public int tagC;
            public bool V;
            public bool D;
        }

        public static DataStruct[] DataStructs;

        public DataCache(int size_DC)
        {
            sizeDC = size_DC;
            DataStructs = new DataStruct[sizeDC];
            for (int i = 0; i < sizeDC; i++)
            {
                DataStructs[i] = new DataStruct();
                DataStructs[i].V = false;
                DataStructs[i].D = false;
            }
        }

        internal static void Add(int data)
        {
            int tag = data / sizeDC;
            int blOff = data % sizeDC;
            DataStructs[blOff].tagC = tag;
            DataStructs[blOff].data = data;
            DataStructs[blOff].V = true;
            DataStructs[blOff].D = true;
        }
    }
}
