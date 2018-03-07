using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKeeper
{
    public abstract class Game
    {
        
      
        public abstract int MinPlayers { get; } //  players minimum 
        public abstract int MaxPlayers { get; }  //  players maximum
        protected abstract bool GameOver { get; }   //  end game requirement met


        public Game() 
        {
            
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
