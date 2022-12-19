using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberClub
{
    public class Tournament
    {
        private List<Team> teams;
        Stack<Match> TournamentMatches;
        private Match FinalMatch;
        public Team TournamentWinner;


        public Tournament(List<Team> TournamentTeams)
        {
            teams = TournamentTeams;
            TournamentMatches = new Stack<Match>();
            TournamentMatches.Push(FinalMatch = new Match());
            TournamentMatches.Push(new Match(teams[0], teams[1]));
            TournamentMatches.Push(new Match(teams[2], teams[3]));
        }

        public Match PlayTournamentMatch()
        {
            if (teams.Count == 2)
            {
                FinalMatch = new Match(teams[0], teams[1]);
                FinalMatch.PlayMatch();
                TournamentWinner = FinalMatch.Winner;
                return FinalMatch;
            }
            else
            {
                Match match = TournamentMatches.Pop();
                match.PlayMatch();
                teams.Remove(match.Loser);
                return match;
            }
        }
    }
}
