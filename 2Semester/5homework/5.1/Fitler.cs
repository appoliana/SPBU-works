using System;

namespace Filter
{
    class FitlerFunction
    {
        public static List<int> Filter(List<int> list, Func<int, bool> func)
        {
            var newList = new List<int>();
            foreach (int value in list)
            {
                newList.Add(func(value));
            }
            return newList;
        }
    }
}
