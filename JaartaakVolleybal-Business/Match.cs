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
        private List<Set> _score; // hoe de punten staan, lijst van sets per match
        private int _gewonnenSetsH; // hoeveel sets team h heeft gewonnen
        private int _gewonnenSetsB; // hoeveel sets team B heeft gewonnen
        private bool _gameOver; // zal je nodig hebben om te bepalen of ene match gespeeld is

        public Match(Team teamHome, Team teamBezoek)
        {
            _teamHome = teamHome;
            _teamBezoek = teamBezoek;
            _score = new List<Set>();
            _gewonnenSetsB = 0;
            _gewonnenSetsH = 0;
            _gameOver = false;
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

        // als je een match speelt dan ben je met 2 he

        public void voegTeamsToe(Team teamHome, Team teamBezoek)
        {
            _teamHome = teamHome;
            _teamBezoek = teamBezoek;
            _teamHome.AantalMatchen ++; //als er een match wordt toegevoegd -> aantalM +1
            _teamBezoek.AantalMatchen++;

        }

        public void voegSetToe(Set sets)
        {
            // terug aanpassen


        }

        //hulpprocedure om te controleren of de match voorbij is. Wordt aangeroepen na het toevoegen van een set
        private void checkWinner()
        {
            //hier ga je moeten checken wie gewonnen heeft of niet
            // maw het aantal gewonnen wedstrijden moet aangepast worden ed.

            //hier kan je dan die gameover op true or false zetten

        }

     }
}

