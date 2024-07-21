using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class MyDictionary <Tkey, Tvalue>
    {

         Tkey[] _keys;
         Tvalue[] _values;

        public MyDictionary()
        {
            _keys = new Tkey[0];
            _values = new Tvalue[0];
        }

        
        public void Add(Tkey keyitem, Tvalue valueitem)
        {
            Tkey[] tempKey;
            Tvalue[] tempvalue;

            tempKey = _keys;
            tempvalue = _values;

            _keys = new Tkey[_keys.Length + 1];
            _values = new Tvalue[_values.Length + 1];

            for(int i = 0; i < tempKey.Length; i++)
            {
                _keys[i] = tempKey[i];
                _values[i] = tempvalue[i];
            }

            _keys[_keys.Length - 1] = keyitem;
            _values[_values.Length - 1] = valueitem;

        }

        public int count
        {
            get { return _keys.Length; }
        }
        

        public void Get()
        {
            for(int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine(_keys[i]);
                Console.WriteLine(_values[i]);
            }
        }



    }
}
