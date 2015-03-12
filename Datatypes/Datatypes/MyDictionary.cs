using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public interface IMyDictionary<K, V> : IEnumerable<MyKVP<K, V>>
    {
        V this[K key] { get; set; }

        Boolean ContainsKey(K key);

        void Add(K key, V value);

        bool TryGetValue(K key, out V value);        

    }

    public class MyDictionary<K, V> : IMyDictionary<K, V> where K:IComparable
    {
        private int size;
        private List<MyKVP<K,V>>[] storage;
        
        public MyDictionary()
        {
            this.size = 5000;
            storage = new List<MyKVP<K, V>>[size];
        }        

        public Boolean ContainsKey(K key)
        {
            int hashedKey = GetHashKey(key);
            return storage[hashedKey] != null;            
        }

        public IEnumerator<MyKVP<K, V>> GetEnumerator()
        {
            for (int i = 0; i < this.size; i++)
            {
                if (storage[i] != null)
                {
                    foreach (var keyValuePair in storage[i])
                    {
                        yield return keyValuePair;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(K key, V value)
        {
            if (ContainsKey(key)) throw new Exception("Key is already present in dictionary");
            
            int hashedKey = GetHashKey(key);
            if (storage[hashedKey] == null)
            {
                storage[hashedKey] = new List<MyKVP<K, V>>();
            }
            storage[hashedKey].Add(new MyKVP<K, V> (key ,value));
        }

        public V this[K key]
        {
            get
            {
                return Get(key);
            }
            set
            {
                int hashedKey = GetHashKey(key);
                foreach (var kvp in storage[hashedKey])
                {
                    if (kvp.Key.CompareTo(key) == 0)
                    {
                        kvp.Value = value;
                        return;
                    }
                }
                throw new Exception("Missing key");
            }
        }

        private V Get(K key)
        {
            if (!ContainsKey(key)) throw new Exception("Key is already present in dictionary");
            int hashedKey = GetHashKey(key);
            foreach (var kvp in storage[hashedKey])
            {
                if (kvp.Key.CompareTo(key) == 0) return kvp.Value;
            }
            throw new Exception("Missing key");
        }

        public bool TryGetValue(K key, out V value)
        {
            if (ContainsKey(key))
            {
                value = Get(key);
                return true;
            }
            value = default(V);
            return false;
        }


        private int GetHashKey(K key)
        {
            return Math.Abs(key.GetHashCode() % size);
        }        
    }

    public class MyKVP<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }

        public MyKVP(K key, V value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
