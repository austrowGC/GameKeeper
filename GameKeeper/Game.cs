using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKeeper
{
    public abstract class Game
    {
        
        protected int PlayerNum
        {
            get { return Atrium.Players.Count(); }
        }
        public abstract int MinPlayers { get; } //  players minimum 
        public abstract int MaxPlayers { get; }  //  players maximum
        protected abstract bool GameOver { get; }   //  end game requirement met


        public Game() 
        {
            
        }

        public void CheckPlayers()    //  extablish players present are of sufficient number   
        {
            if (MinPlayers >= PlayerNum || PlayerNum >= MaxPlayers)    //  outside bounds
            {
                //  game handles only a set number of players
                if (MinPlayers == MaxPlayers)  
                {
                    throw new Exception($"{MaxPlayers} players required.");
                }
                //  game handles variable number of players
                else
                {
                    throw new Exception($"{MinPlayers} to {MaxPlayers} players required.");
                }
            }
        }

        public void PlayGame()  // plays the game
        {
            Setup();
            while (!GameOver)
            {
                Round();
                GetGameOver();
            }
            StopGame();
        }
        
            
        public abstract void Setup();
        public abstract void Round();
        protected abstract bool GetGameOver();

        public abstract void StopGame();

        //protected FindPlayerName(string)

    }
}
