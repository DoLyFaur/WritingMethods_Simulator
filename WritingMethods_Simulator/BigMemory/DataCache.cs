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
            int data;
            int tagC;
            bool V;
            bool D;
        }

        DataStruct[] DataStructs = new DataStruct[sizeDC];

        public DataCache(int size_DC)
        {
            sizeDC = size_DC;
        }
    }
}
