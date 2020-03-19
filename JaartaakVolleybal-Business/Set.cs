using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVolleybal_Business
{
     public class Set
    {
        private int _puntenHome; // de punten van het team dat thuis speelt
        private int _puntenBezoek; // de punten van het team dat op bezoek komt

        public Set(int puntenHome, int puntenBezoek)
        {
           _puntenHome = puntenHome;
           _puntenBezoek = puntenBezoek;
        }

        public int PuntenHome
        {
            get { return _puntenHome; }
        }

        public int PuntenBezoek
        {
            get { return _puntenBezoek; }
        }

        public void voegPuntenHomeToe(int punten)
        {
            _puntenHome = punten;  // je voegt gewoon de punten van een set toe bv. 25
        }

        public void voegPuntenBezoekToe(int punten)
        {
            _puntenBezoek = punten;
        }

        // de methode wisselScore() hoef je niet te doen. 

    }
}

