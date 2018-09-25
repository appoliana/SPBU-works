using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMap
{
    /// <summary>
    /// Класс, который реализует движение @ по карте.
    /// </summary>
    public class EventLoop
    {
        public string[] arrayOfMap;
        public int ourDogCollumn;
        public int ourDogLine;

        public void MoveDog(string vector)
        {
            switch (vector)
            {
                case "left":
                    changeOurDogPlace(arrayOfMap, ourDogLine, --ourDogCollumn, ourDogLine, ourDogCollumn + 1);
                    break;
                case "right":
                    changeOurDogPlace(arrayOfMap, ourDogLine, ++ourDogCollumn, ourDogLine, ourDogCollumn - 1);
                    break;
                case "up":
                    changeOurDogPlace(arrayOfMap, --ourDogLine, ourDogCollumn, ourDogLine + 1, ourDogCollumn);
                    break;
                case "down":
                    changeOurDogPlace(arrayOfMap, ++ourDogLine, ourDogCollumn, ourDogLine - 1, ourDogCollumn);
                    break;
                default:
                    // закрыть файл
                    // file.Close();
                    break;
            }
        }
        /// <summary>
        /// Метод, который реагирует на нажатие клавиши.
        /// </summary>
        /// <param name="ourDogLine"></param>
        /// <param name="ourDogCollumn"></param>
        /// <param name="arrayOfMap"></param>

        public void Run(int ourDogLineIn, int ourDogCollumnIn, string [] arrayOfMapIn)
        {

            ourDogCollumn = ourDogCollumnIn;
            ourDogLine = ourDogLineIn;
            arrayOfMap = arrayOfMapIn;
            printArray(arrayOfMap);

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (arrayOfMap[ourDogLine].ElementAt(ourDogCollumn - 1) != '*')
                        {
                            MoveDog("left");
                            Console.Clear();
                            printArray(arrayOfMap);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (arrayOfMap[ourDogLine].ElementAt(ourDogCollumn + 1) != '*')
                        {
                            MoveDog("right");
                            Console.Clear();
                            printArray(arrayOfMap);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (arrayOfMap[ourDogLine - 1].ElementAt(ourDogCollumn) != '*')
                        {
                            MoveDog("up");
                            Console.Clear();
                            printArray(arrayOfMap);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (arrayOfMap[ourDogLine + 1].ElementAt(ourDogCollumn) != '*')
                        {
                            MoveDog("down");
                            Console.Clear();
                            printArray(arrayOfMap);
                        }
                        break;
                    case ConsoleKey.Escape:
                        //move on escape
                        return;
                }
            }
        }

        /// <summary>
        /// Метод, который метяет положение @.
        /// </summary>
        /// <param name="arrayOfMap"></param>
        /// <param name="newLine"></param>
        /// <param name="newCollumn"></param>
        /// <param name="oldLine"></param>
        /// <param name="oldCollumn"></param>

        public void changeOurDogPlace(string [] arrayOfMap, int newLine, int newCollumn, int oldLine, int oldCollumn)
        {
            arrayOfMap[oldLine] = replaceCharInString(arrayOfMap[oldLine], oldCollumn, ' ');
            arrayOfMap[newLine] = replaceCharInString(arrayOfMap[newLine], newCollumn, '@');
        }
        /// <summary>
        /// Метод, который заменяет символ.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="index"></param>
        /// <param name="newSymbol"></param>
        /// <returns></returns>

        public string replaceCharInString(string source, int index, char newSymbol)
        {
            char[] chars = source.ToCharArray();
            chars[index] = newSymbol;
            return new string(chars);
        }
        /// <summary>
        /// Метод, который печатает массив.
        /// </summary>
        /// <param name="arrayOfMap"></param>

        public void printArray(string[] arrayOfMap)
        {
            for (int i = 0; i < 6; ++i)
            {
                Console.WriteLine(arrayOfMap[i]);
            }
        }
    }
}