using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.Stack___Queue__HashMap_and_Hashing_Function.HashMaps
{
    class CustomHashMap
    {
        int[] keys;
        int[] values;
        int size;
        int capacity = 20;
        public CustomHashMap()
        {
            keys = new int[capacity];
            values = new int[capacity];
            for (int i = 0; i < capacity; i++)
                keys[i] = int.MinValue;
        }
        private int Hash(int key)
        {
            return Math.Abs(key) % capacity;
        }
        public void Put(int key, int value)
        {
            int index = Hash(key);
            while (keys[index] != int.MinValue && keys[index] != key)
            {
                index = (index + 1) % capacity;
            }
            keys[index] = key;
            values[index] = value;
        }
        public bool ContainsKey(int key)
        {
            int index = Hash(key);
            int start = index;
            while (keys[index] != int.MinValue)
            {
                if (keys[index] == key)
                    return true;
                index = (index + 1) % capacity;
                if (index == start)
                    break;
            }
            return false;
        }
        public int Get(int key)
        {
            int index = Hash(key);
            int start = index;

            while (keys[index] != int.MinValue)
            {
                if (keys[index] == key)
                    return values[index];

                index = (index + 1) % capacity;
                if (index == start)
                    break;
            }
            return -1;
        }
    }

}
