﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVolleybal_Business
{
     public class Team
    {
        private string _naam; // naam van het team
        private int _matchGewonnen; // matchen die het team gewonnen geeft
        private int _matchVerloren; // matchen die team verloren geeft
        private int _aantalMatchen; // het aantal matchen team al geeft gespeeld
        private int _gewonnenSets; // aantal sets team geeft gewonnen
        private int _aantalSets; // aantal gespeelde sets 

        public Team(string naam)
        {
            _naam = naam;
            _matchGewonnen = 0;
            _matchVerloren = 0;
            _aantalMatchen = 0;
            _gewonnenSets = 0;
            _aantalSets = 0;
        }
        public Team()
        {
            _naam = "vbc Sint-joris";
            _matchGewonnen = 0;
            _matchVerloren = 0;
            _aantalMatchen = 0;
            _gewonnenSets = 0;
            _aantalSets = 0;
        }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public int MatchGewonnen
        {
            get { return _matchGewonnen; }
        }
        public int MatchVerloren
        {
            get { return _matchVerloren; }
        }
        public int AantalMatchen
        {
            get { return _aantalMatchen; }
        }
        public int GewonnenSets
        {
            get { return _gewonnenSets; }
        }
        public int AantalSets
        {
            get { return _aantalSets; }
        }
        public int berekenPunten()
        {

        }
        public override string ToString()
        {
            return;
        }
    }
}
