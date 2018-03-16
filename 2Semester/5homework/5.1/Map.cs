using System;
using System.Collections.Generic;

namespace Map
{
    class MapFunction
    {
        public static List<int> Map(List<int> list, Func<int, int> func)
        {
            var newList = new List<int>();
            foreach(int value in list)
            {  
                newList.Add(func(value));
            }
            return newList;
        }
    }
}
