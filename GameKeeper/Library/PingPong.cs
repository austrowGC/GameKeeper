using System;
using GameKeeper.Interfaces;

namespace GameKeeper.Library
{
    public class PingPong : PointGame
    {
        private const int _minPlayers = 2;
        private int _maxPlayers = _minPlayers;
        public override int MinPlayers   
        {
            get
            {
                return _minPlayers;
            }
        }
        public override int MaxPlayers   
        {
            get
            {
                return _maxPlayers;
            }
        }

        public PingPong(int count) : base(count) { }

        protected override bool GameOver
        {
            get
            {
                return GetGameOver();
            }
        }
        

        public override void Round()
        {
            
        }

        public override void Setup()
        {
            //CheckPlayers();
        }

        public override void StopGame()
        {
            
        }

        protected override bool GetGameOver()
        {
            bool ans = false;
            foreach (int score in Points)
            {
                if (score >= EndScore)
                {
                    ans = true;
                }
            }
            return ans;
        }
    }
}
