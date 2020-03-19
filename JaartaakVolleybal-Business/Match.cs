using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVolleybal_Business
{
     public class Match
    {
        private Team _teamHome; // het team dat thuis speelt
        private Team _teamBezoek; // het team dat op  bezoek speelt
        private List<Set> _score; // hoe de punten staan
        private int _gewonnenSetsH; // hoeveel sets team h heeft gewonnen
        private int _gewonnenSetsB; // hoeveel sets team B heeft gewonnen

        public Match(Team teamHome, Team teamBezoek)
        {
            _teamHome = teamHome;
            _teamBezoek = teamBezoek;
            _score = new List<Set>();
            _gewonnenSetsB = 0;
            _gewonnenSetsH = 0;
        }
        public Team TeamHome
        {
            get { return _teamHome; }
            set { _teamHome = value; }
        }

        public Team TeamBezoek
        {
            get { return _teamBezoek; }
            set { _teamBezoek = value; }
        }

        public List<Set> Score
        {
            get { return _score; }
        }

        public int GewonnenSetsB
        {
            get { return _gewonnenSetsB; }
        }

        public int GewonnenSetsH
        {
            get { return _gewonnenSetsH; }
        }

        public void voegTeamHomeToe(Team teams)
        {
            _teamHome.Add(teams);
        }

        public void voegSetToe(Set sets)
        {
            _score.Add(sets);
        }

     }
}
}
