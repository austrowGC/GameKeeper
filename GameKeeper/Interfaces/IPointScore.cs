using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameKeeper.Interfaces
{
    interface IPointScore
    {
        int EndScore { get; set; }

        void ScorePoint();

    }
}
