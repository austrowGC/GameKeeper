using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKeeper
{
    public class Player
    {
        string _firstN;
        string _lastN;

        protected string NameF  
        {
            get
            {
                string first = _firstN.Substring(0, 1).ToUpper() + _firstN.Substring(1).ToLower();
                return first;
            }
        }
        protected string NameL  
        {
            get
            {
                string last = _lastN.Substring(0, 1).ToUpper() + _lastN.Substring(1).ToLower();
                return last;
            }
        }
        public string Name      
        {
            get
            {
                return $"{NameF} {NameL}";
            }
        }
        public string Handle    
        {
            get;
            private set;
        }

        public Player()
        {
            Console.Write(@"Input player username:\t");
            Handle = Console.ReadLine();
        }

    }
}
