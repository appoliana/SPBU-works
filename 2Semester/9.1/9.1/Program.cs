using System;

namespace Infinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите enter чтобы получить следубщее число или 0 чтобы выйти");
            foreach (int number in Infinite.InfiniteSequence.GetNumbers())
            {
                var input = Console.ReadLine();
                if (input == "0")
                {
                    return;
                }
                Console.Write(number);
            }
        }
    }
}
