using System;
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
        {
            int totaal =  ...;

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
