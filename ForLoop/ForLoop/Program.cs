using System;

namespace ForLoop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i<=100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.ReadKey();
        }
    }
}
