using MyApp;

namespace Kakoito_minys_vaib
{
    public class Key
    {
        public static int CheckPos(int min, int max)
        {
            int position = min;
            ConsoleKeyInfo key;

            while (true)
            {
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                Console.SetCursorPosition(0, 0);
                key = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.Write("  ");

                if (key.Key == ConsoleKey.UpArrow && position > min)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow && position < max)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    return position;
                }
                else if (key.Key == ConsoleKey.F1)
                {
                    return -1;
                }
                else if (key.Key == ConsoleKey.F2)
                {
                    return -2;
                }
                else if (key.Key == ConsoleKey.S)
                {
                    return -5;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    return -10;
                }
                else if (key.Key == ConsoleKey.Delete)
                {
                    return -15;
                }
            }
        }
    }
}