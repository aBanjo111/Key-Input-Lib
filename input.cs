using System;

namespace key_input_lib
{
    public class Input
    {
        public static string keypressed = "";
        public bool Keypressed(string key)
        {
            while (true)
            {
                ConsoleKeyInfo keypressed = Console.ReadKey();
                if (key.ToUpperInvariant() == keypressed.Key.ToString())
                {
                    return true;
                }
                
            }
        }


    }
}
