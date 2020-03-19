using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaartaakVolleybal_Business
{
    public class Volleyteam
    {

        private string _naam;


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
