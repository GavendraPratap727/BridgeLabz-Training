using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.ExamProctor
{
    //custom hash map using 2 arrays 
    class CustomHashMap
    {
        private int[] keys; //to store key 
        private string[] values;  // to store value
        private int count;

        public CustomHashMap(int size)
        {
            keys = new int[size];
            values = new string[size];
            count = 0;
        }

        public void Put(int key, string value)
        {
            for (int i = 0; i < count; i++)
            {
                if (keys[i] == key)
                {
                    values[i] = value;
                    return;
                }
            }

            keys[count] = key;
            values[count] = value;
            count++;
        }

        public string Get(int key)
        {
            for (int i = 0; i < count; i++)
            {
                if (keys[i] == key)
                    return values[i];
            }
            return null;
        }

        public int Size()
        {
            return count;
        }
       
        public int GetKeyAt(int index)
        {
            return keys[index];
        }
    }
}
