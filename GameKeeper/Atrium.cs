using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameKeeper
{
    public class Atrium
    {
        const string dbConnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=GameKeeper;Integrated Security = True";
        const int sleep_ms = 1000;
        private ConsoleKey _key;

        const char command_newPlayer = '1';
        const char command_addPlayer = '2';
        const char command_chooseGame = '3';

        private List<Player> _players = new List<Player>();
        public Player[] Players
        {
            get
            {
                return _players.ToArray();
            }
        }

        public Atrium()
        {
        }

        public void Start()     
        {
            PrintHeader();
            PrintMenu();
            while(_key != ConsoleKey.Escape)
            {
                switch (_key)
                {
                    case command_newPlayer:
                        CreatePlayer();
                        break;
                    case command_addPlayer:
                        AddPlayer();
                        break;
                    case command_chooseGame:
                        SelectGame();
                        break;
                }
                wait();
            }

        }

        void KeyInput()      
        {
            _key = Console.ReadKey(true).Key;   //  displays nothing to console
        }

        void PrintHeader()      
        {
            Console.WriteLine("This is the Lobby Header");
        }
        void PrintMenu()        
        {
            Console.WriteLine();
            Console.WriteLine($"[{command_newPlayer}]\tCreate new player");
            Console.WriteLine($"[{command_addPlayer}]\tAdd a player to the lobby");
            Console.WriteLine($"[{command_chooseGame}]\tChoose a game");

            Console.WriteLine("[ESC]\tQuit");
            Console.WriteLine();
        }

        void AddPlayer()        
        {
            Console.WriteLine("coming soon");
        }
        void CreatePlayer()     
        {
            Console.WriteLine("coming soon");
        }
        void SelectGame()       
        {
            Console.WriteLine("coming soon");
        }


        void wait()
        {
            Thread.Sleep(sleep_ms);
        }
    }
}
