using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKeeper
{
    public class Atrium
    {
        private static List<Player> _players = new List<Player>();
        public static Player[] Players 
        {
            get
            {
                return _players.ToArray();
            }
        }

        //  @"Data Source=.\SQLEXPRESS;Initial Catalog=World;Integrated Security = True";

        public static void AddPlayer()
        {
            _players.Add(new Player());
        }
    }
}
