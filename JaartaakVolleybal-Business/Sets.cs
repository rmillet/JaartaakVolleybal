using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVolleybal_Business
{
     public class Sets
    {
        private int _puntenHome; // de punten van het team dat thuis speelt
        private int _puntenBezoek; // de punten van het team dat op bezoek komt

        public Sets(int puntenHome, int puntenBezoek)
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

        public void voegPuntenHomeToe(Set punten)
        {
            _puntenHome.Add(punten);
        }

        public void voegPuntenBezoekToe(Set punten)
        {
            _puntenBezoek.Add(punten);
        }
    }
}
}
