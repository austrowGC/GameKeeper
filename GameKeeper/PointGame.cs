using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKeeper
{
    public abstract class PointGame : Game
    {
        protected List<int> _points = new List<int>();

        protected override bool GameOver
        {
            get
            {
                return GetGameOver();
            }
        }

        public int[] Points 
        {
            get
            {
                return _points.ToArray();
            }
        }
        protected int EndScore { get; private set; }

        public PointGame(int count) : base()
        {
            EndScore = count;
        }

        public void Accrue(int index)
        {
            _points[index]++;
        }
        public void Accrue(int index, int points)
        {
            _points[index] += points;
        }

        public void Reduce(int index)
        {
            _points[index]--;
        }
        public void Reduce(int index, int points)
        {
            _points[index] -= points;
        }

       
    }
}
