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
        private int _gewonnenSets; // aantal sets team heeft gewonnen
        private int _verlorenSets; // aantal sets team heeft verloren
        private int _aantalSets; // aantal gespeelde sets 
        private int punten;// het aantal punten van een team

        public Team(string naam)
        {
            _naam = naam;
            _matchGewonnen = 0;
            _matchVerloren = 0;
            _aantalMatchen = 0;
            _gewonnenSets = 0;
            _verlorenSets = 0;
            _aantalSets = 0;
        }
        public Team()
        {
            _naam = "vbc Sint-joris";
            _matchGewonnen = 0;
            _matchVerloren = 0;
            _aantalMatchen = 0;
            _gewonnenSets = 0;
            _verlorenSets = 0;
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
            set { _matchGewonnen = value; }
        }
        public int MatchVerloren
        {
            get { return _matchVerloren; }
            set { _matchVerloren = value; }
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
        public int VerlorenSets
        {
            get { return _verlorenSets; }
            set { _verlorenSets = value; } // je moet het aantal verloren sets kunnen aanpassen.
        }
        public int AantalSets
        {
            get { return _aantalSets; }
            set { _aantalSets = value; } // je moet het aantal sets kunnen aanpassen
            
        }

        // eigenschap punten toevoegen
        public int puntenToevoegen
        {
            get { return punten; }
            set { punten = value; }
        }

        
        

        public int berekenPunten()
        {   // ik denk dat we zoiets moeten doen Match gewonnen als je 3 sets wint.
           
            int totaal = 0;// _gewonnenSets-_matchGewonnen; dit klopt niet

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
