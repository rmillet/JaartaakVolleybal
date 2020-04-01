using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVolleybal_Business
{
      public class Competitie
    {
        private List<Match> _matchen; //gebruik beter meervoud is een lijst 
        private List<Team> _teams;
        public Competitie()
        {
            _matchen = new List<Match>();
            _teams = new List<Team>(); 
        }

        public List<Match> Match
        {
            get { return _matchen; }
        }

        public List<Team> Team
        {
            get { return _teams; }
        }

        public void voegTeamToe(Team team)
        {
            _teams.Add(team);
        }

        public void voegMatchToe(Match match) // je voegt 1 match toe aan een lijst matchen
        {
            _matchen.Add(match);
        }

        // dit heb je niet nodig
        /*public void vraagMatchOp(Team teams)
        {
            _team.Add(teams);
        }*/

        public Team vraagTeamOp (string naam) // je vraagt een team op basis van de naam
        {
           Team resultaatteam = null;
            
            // dus dit is niet correct... 
            //je moet dus op zoak gaan nar het team met de naam 
            // die je hebt megegeven als parameter
            //
            for (int i = _teams.Count - 1; i >= 0; i--)
            {
               if (Team[i].Naam == naam)
                {
                    // temp.Add(temp);
                    resultaatteam = Team[i];
                }

            } 
            return resultaatteam;
            
        }       

    }
}

