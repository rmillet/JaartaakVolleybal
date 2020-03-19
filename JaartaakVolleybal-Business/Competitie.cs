using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVolleybal_Business
{
      public class Competitie
    {
        private List<Match> _match;
        private List<Team> _team;
        public Competitie()
        {
            _match = new List<Match>();
            _team = new List<Team>(); 
        }

        public List<Match> Match
        {
            get { return _match; }
        }

        public List<Team> Team
        {
            get { return _team; }
        }

        public void voegTeamToe(Team teams)
        {
            _team.Add(teams);
        }

        public void voegMatchToe(Match matchen)
        {
            _match.Add(matchen);
        }

        public void vraagMatchOp(Team teams)
        {
            _team.Add(teams);
        }

        public Team vraagTeamO(int nr)
        {
            if (nr >= 0 && nr < hoeveelingredienten())
            {
                return _team[nr];
            }
            else
            {
                return null;
            }
        }
        public string vraagTeamOp(int nr)
        {
            if (nr >= 0 && nr < _team.Count)
            {
                return _team[nr].Naam;
            }
            else
            {
                return " ";
            }
        }

        public string vraagMatchOp(int nr)
        {
            if (nr >= 0 && nr < _match.Count)
            {
                return _team[nr].Naam;
            }
            else
            {
                return " ";
            }
        }

    }
}
}
