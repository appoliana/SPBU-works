using System;
using System.Collections.Generic;

namespace FoldFilterAndMap
{
    /// <summary>
    /// Класс, который реализует методы Fold, Filter and Map.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class FoldFilterAndMapFunction
    {
        /// <summary>
        /// Метод, который возвращает накопленное значение.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="begginingValue"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Y Fold<T, Y>(List<T> list, Y begginingValue, Func<T, Y, Y> func)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                begginingValue = func(list[i], begginingValue);
            }

            return begginingValue;
        }

        /// <summary>
        /// Метод, который отбирает элементы из списка.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static List<T> Filter<T>(List<T> list, Func<T, bool> function)
        {
            var resultList = new List<T>();

            foreach (T element in list)
            {
                if (function(element))
                {
                    resultList.Add(element);
                }
            }

            return resultList;
        }

        /// <summary>
        /// Метод, который преобразует элементы списка.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static List<Y> Map<T, Y>(List<T> list, Func<T, Y> func)
        {
            var newList = new List<Y>();
            foreach (var value in list)
            {
                newList.Add(func(value));
            }

            return newList;
        }
    }
}
