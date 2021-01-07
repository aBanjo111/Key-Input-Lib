using System;
﻿using System.Threading;

namespace key_input_lib
{
    public class Input
    {
        public static string keyisdown = "";
        public Keypressed()
        {
            public static bool stopthis = false;
            while (true)
            {
                ConsoleKeyInfo keyisdown = Console.ReadKey();
                keyisdown = keypressed.Key.ToString();
                
                Thread.Sleep(5);
                
                if (stopthis == true)
                {
                    return "";
                }
            }
        }


    }
}
