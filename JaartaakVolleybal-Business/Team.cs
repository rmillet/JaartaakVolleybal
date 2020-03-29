using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVolleybal_Business
{
     public class Team
    { // kdenk deze klaar ma ik weet niet of berekenpunten juist is 
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
            set { _aantalMatchen = value; } // je moet het aantal matchen kunnen aanpassen
        }
        //dus ook voor de rest!!!
        //je moet telkens ook kunnen aanpassen
        //dus overal sets

        public int GewonnenSets
        {
            get { return _gewonnenSets; }
            set { _gewonnenSets = value; } // je moet het aantal gewonnen sets kunnen aanpassen
        }
        public int AantalSets
        {
            get { return _aantalSets; }
            set { _aantalSets = value; } // je moet het aantal sets kunnen aanpassen
            //Glenn
        }
        public int berekenPunten()
        {   // ik denk dat we zoiets moeten doen Match gewonnen als je 3 sets wint.
            // set win je als je 25 punten hebt met 2 punten verschil
            //Als je match met 3-0 of 3-1 wint krijg je 3 punten , Als je met 3-2 wint dan krijg je 2 punten
            // als je match verliest met 0-3 of 1-3 dan krijg je 0 punten als je verliest met 2-3 krijg je 1 punt
            int totaal = _gewonnenSets-_matchGewonnen;

            return totaal; 
        }
        
        //override van ToString

        /// <summary>
        /// Geeft de naam terug als formaat
        /// </summary>
        /// <returns>Naam van het team</returns>
        public override string ToString()
        {
            return _naam;
        }

    }
}
