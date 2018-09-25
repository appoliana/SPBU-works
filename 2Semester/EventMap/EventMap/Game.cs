using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMap
{
    /// <summary>
    /// Класс, который отвечает за связь клавиш и карты.
    /// </summary>
    public class Game
    {
        public string[] arrayOfMap;
        public int ourDogCollumn;
        public int ourDogLine;

        /// <summary>
        /// Конструктор, который принимает карту и печатает ее.
        /// </summary>
        public Game()
        {
            var reader = new MyReader();
            (this.arrayOfMap, this.ourDogLine, this.ourDogCollumn) = reader.ReadMapFromFile();
            printArray(arrayOfMap);
        }

        /// <summary>
        /// Метод, в котором реализовано движение собаки при нажатии клавиши "влево".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLeft(object sender, EventArgs args)
        {
            if (arrayOfMap[ourDogLine].ElementAt(ourDogCollumn - 1) != '*')
            {
                Console.Clear();
                changeOurDogPlace(arrayOfMap, ourDogLine, --ourDogCollumn, ourDogLine, ourDogCollumn + 1);
                printArray(arrayOfMap);
            }

        }

        public (int, int) returnDog() => (ourDogCollumn, ourDogLine);

        /// <summary>
        /// Метод, в котором реализовано движение собаки при нажатии клавиши "вправо".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnRight(object sender, EventArgs args)
        {  
            if (arrayOfMap[ourDogLine].ElementAt(ourDogCollumn + 1) != '*')
            {
                Console.Clear();
                changeOurDogPlace(arrayOfMap, ourDogLine, ++ourDogCollumn, ourDogLine, ourDogCollumn - 1);
                printArray(arrayOfMap);
            }
        }

        /// <summary>
        /// Метод, в котором реализовано движение собаки при нажатии клавиши "вверх".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnTop(object sender, EventArgs args)
        {  
            if (arrayOfMap[ourDogLine - 1].ElementAt(ourDogCollumn) != '*')
            {
                Console.Clear();
                changeOurDogPlace(arrayOfMap, --ourDogLine, ourDogCollumn, ourDogLine + 1, ourDogCollumn);
                printArray(arrayOfMap);
            }
        }

        /// <summary>
        /// Метод, в котором реализовано движение собаки при нажатии клавиши "вниз".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDown(object sender, EventArgs args)
        {
            if (arrayOfMap[ourDogLine + 1].ElementAt(ourDogCollumn) != '*')
            {
                Console.Clear();
                changeOurDogPlace(arrayOfMap, ++ourDogLine, ourDogCollumn, ourDogLine - 1, ourDogCollumn);
                printArray(arrayOfMap);
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
        public void changeOurDogPlace(string[] arrayOfMap, int newLine, int newCollumn, int oldLine, int oldCollumn)
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
        /// Метод, который печатает карту.
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
