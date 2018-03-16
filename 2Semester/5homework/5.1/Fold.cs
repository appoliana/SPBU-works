using System;

namespace Fold
{
    class FoldFunction
    {
        public static List<int> Fold(List<int> list, int begginingValue, Func<int, int> func)
        {
            var result = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                result = func(begginingValue, list[i]);
            }
            return result;
        }
    }
}
