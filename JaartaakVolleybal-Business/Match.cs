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
            if (_gameOver == false)
            {
                if (sets.PuntenHome > sets.PuntenBezoek)
                {
                    _teamHome.GewonnenSets++;
                    _teamBezoek.VerlorenSets++;

                    _gewonnenSetsH++;
                }
                else
                {
                    _teamHome.VerlorenSets++;
                    _teamBezoek.GewonnenSets++;


                    _gewonnenSetsB++;
                }
            }
            checkWinner();

            if (_gameOver == true)
            { 
            // mogelijkheid voorzien om de eigenschap "punten " van elk team aan te passen
            // moet je in klasse team een eigenschap "punten" toevoegen
            // set win je als je 25 punten hebt met 2 punten verschil
            //Als je match met 3-0 of 3-1 wint krijg je 3 punten , Als je met 3-2 wint dan krijg je 2 punten
            // als je match verliest met 0-3 of 1-3 dan krijg je 0 punten als je verliest met 2-3 krijg je 1 punt{

             }
    }

        //hulpprocedure om te controleren of de match voorbij is. Wordt aangeroepen na het toevoegen van een set
        private void checkWinner()
        {
            if (_gewonnenSetsH == 3)
            {
                _teamHome.MatchGewonnen++;
                _teamBezoek.MatchVerloren++;
                _gameOver = true; //dit betekent dat de match gespeeld is en dit dus de definitieve resultaten zijn.
                _teamHome.AantalMatchen++;
                _teamBezoek.AantalMatchen++;
            }
            
            if (_gewonnenSetsB == 3)
            {
                _teamHome.MatchVerloren++;
                _teamBezoek.MatchGewonnen++;
                _gameOver = true; //de match is over en dit zijn de resultaten
                _teamHome.AantalMatchen++;
                _teamBezoek.AantalMatchen++;
            }

        }

     }
}

