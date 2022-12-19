using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberClub
{
    public class Match
    {
        private int chance;
        private Team teamA;
        private Team teamB;
        private Random random;
        public Team Winner;
        public Team Loser;

        public Match(Team firstTeam, Team secondTeam)
        { 
            teamA = firstTeam;
            teamB = secondTeam;
            random = new Random();
        }

        public Match()
        {
            random = new Random();
        }

        public void PlayMatch()
        {
            var result = random.Next(1, 3);
            if (result == 1)
            {
                Winner = teamA;
                Loser = teamB;
            }
            else
            {
                Winner = teamB;
                Loser = teamA;
            }

        }
    }
}
