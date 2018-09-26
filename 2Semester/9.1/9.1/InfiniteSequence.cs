using System.Collections.Generic;
using System;

namespace Infinite
{    
    public static class InfiniteSequence
    {
        /// <summary>
        /// Метод, который возвращает бесконечную последовательность простых чисел.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<int> GetNumbers()
        {
            var value = 1;
            while (true)
            {
                ++value;
                if (Filter(value))
                {
                    yield return value;
                }
            }
        }

        /// <summary>
        /// Метод, который говорит, простое это число или нет.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static bool Filter(int number)
        {
            int divider = 2;
            while (divider < Math.Sqrt(number))
            {
                if (number % divider == 0)
                {
                    return false;
                }
                ++divider;
            }
            return true;
        }
    }
}