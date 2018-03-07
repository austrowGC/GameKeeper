using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKeeper
{
    public class Session
    {
        private static ConsoleKeyInfo _key;

        public static void KeyInput()
        {
            _key = Console.ReadKey(true);   //  displays nothing to console
        }

    }
}
