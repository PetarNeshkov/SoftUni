using System;
using System.Collections.Generic;
using System.Text;

namespace Fast_Hash_Implementation
{
    class SetElement
    {
        public List<string> Keys { get; set; }
        public string Key { get; set; }
    }
    public class StringHashSet
    {
        private SetElement[] array;
        public StringHashSet(int capacity = 8)
        {
            array = new SetElement[capacity];
        }
        public void Add(string key)
        {
            int index = HashFunction(key);
            if (array[index] != null)
            {
                array[index].Keys.Add(key);
            }
            else
            {
                array[HashFunction(key)] = new SetElement() { Keys = new List<string>() { key } };
            }
        }
        private int HashFunction(string key)
        {
            UInt64 hashedValue = 3074457345618258791ul;
            for (int i = 0; i < key.Length; i++)
            {
                hashedValue += key[i];
                hashedValue *= 3074457345618258791ul;
            }
            UInt64 count = (ulong)array.Length;
            return (int)(hashedValue % count);
        
        }
        public bool Contains(string key)
        {
            int index = HashFunction(key);
            if (array[index] != null)
            {
                for (int i = 0; i < array[index].Keys.Count; i++)
                {
                    if (array[index].Keys[i] == key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
