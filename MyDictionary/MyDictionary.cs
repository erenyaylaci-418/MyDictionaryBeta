using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryBeta
{
    class MyDictionary<Type1, Type2>
    {
        Type1[] firstitems;
        Type2[] seconditems;

        public MyDictionary()
        {
            firstitems = new Type1[0];
            seconditems = new Type2[0];
        }
        public void Add(Type1 item1, Type2 item2)
        {
            Type1[] tmp1 = firstitems;
            Type2[] tmp2 = seconditems;
            firstitems = new Type1[firstitems.Length + 1];
            seconditems = new Type2[seconditems.Length + 1];

            for (int i = 0; i < tmp1.Length; i++)
            {
                firstitems[i] = tmp1[i];
                seconditems[i] = tmp2[i];
            }
            firstitems[firstitems.Length - 1] = item1;
            seconditems[seconditems.Length - 1] = item2;

        }

        public Type1[] First
        {
            get { return firstitems; }
        }
        public Type2[] Second
        {
            get { return seconditems; }
        }
        public int Lenght
        {
            get { return firstitems.Length; }
        }


    }
}
