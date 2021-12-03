using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingMethods_Simulator.BigMemory
{
    class DataCache
    {
        private static int sizeDC;
        public struct DataStruct
        {
            public int data;
            public int tagC;
            public bool V;
            public bool D;
        }

        DataStruct[] DataStructs = new DataStruct[sizeDC];

        public DataCache(int size_DC)
        {
            sizeDC = size_DC;
            for (int i = 0; i < sizeDC; i++)
            {
                DataStructs[i] = new DataStruct();
                DataStructs[i].V = false;
                DataStructs[i].D = false;
            }
        }
    }
}
