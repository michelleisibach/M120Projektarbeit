using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoplätzeverwaltungstool
{  
    class showDescription
    {
        private string titel;
        private string description;

        public void changeDescription(string filmname)
        {
            if(filmname == "film1")
            {
                titel = "Titanic";
                description = "Im Film Titanic geht es um ein Schiff welches untergeht.";
                
                
            }
        }
    }
}
