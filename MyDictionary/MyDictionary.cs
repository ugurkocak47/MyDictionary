using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];

        }

        public void Add(K id,V name)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;

            keys = new K[keys.Length+1];
            values = new V[values.Length+1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = id;
            values[values.Length - 1] = name;
        }

        

        public int Count
        {
            get { return keys.Length; }
        }


        public void ShowMyDictionaryList()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Id: " + keys[i] + "  " + "Name: " + values[i]);
            }
        }
    }
}
