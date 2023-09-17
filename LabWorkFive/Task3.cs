using System;
using System.Collections;
using System.Collections.Generic;

namespace LabWorkFive
{
    class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private TKey[] keys;
        private TValue[] values;
        private int amount;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
            amount = 0;
        }

        public void Add(TKey key, TValue val)
        {
            amount++;
            Array.Resize(ref keys, amount);
            Array.Resize(ref values, amount);
            keys[amount - 1] = key;
            values[amount - 1] = val;
        }

        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < amount; i++)
                {
                    if (object.Equals(keys[i], key))
                    {
                        return values[i];
                    }
                }
                throw new KeyNotFoundException("Key not found");
            }
        }


        public int GetAmount
        {
            get { return amount; }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < amount; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
