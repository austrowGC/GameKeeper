using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKeeper
{
    public class Player
    {
        private int id          { get; }
        public string name    { get; }

        public Player()     
        {

        }

        public Player(string name)  
        {
            this.name = name;
        }

    }
}
