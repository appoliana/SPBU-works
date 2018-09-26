using System.Collections.Generic;
using System;

namespace Infinite
{    
    public static class InfiniteSequence
    {
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





/*
            /// <summary>
            /// Метод, который возвращает бесконечную последовательность чисел.
            /// </summary>
            public static IEnumerable<int> GetNumbers
            {
                get
                { 
                    int number = 3;
                    while (true)
                    {
                        yield return number++;
                    }
                }
            }

            /// <summary>
            /// Передает последовательность до определенного числа.
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="e"></param>
            /// <param name="n"></param>
            /// <returns></returns>
            public static IEnumerable<T> Take<T>(this IEnumerable<T> e, int n)
            {
                var r = e.GetEnumerator();
                for (int i = 0; i < n; i++)
                {
                    r.MoveNext();
                    yield return r.Current;
                }
            }
        }

        /// <summary>
        /// Класс для реализации функции Filter.
        /// </summary>
        public class FitlerFunction
        {
            /// <summary>
            /// Возвращает последовательность простых чисел.
            /// </summary>
            /// <param name="range"></param>
            /// <returns></returns>
            public static IEnumerable<int> Filter(IEnumerable<int> sequence, Func<int, bool> predicate)
            {
                var newSequence = new IEnumerable<int>();
                foreach (int value in sequence)
                {
                    bool flag = false;
                    for (int i = 2; i <= Math.Sqrt(value); ++i)
                    {
                        if (value % i == 0)
                        {
                            flag = true;
                            break;   
                        }
                    }
                    if (!flag)
                    {
                        newList.Add(value);
                    }
                }
                return newList;
            }
        }
        */
