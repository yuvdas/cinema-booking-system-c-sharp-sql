using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingSystem
{
    class GlobalVariables
    {
       public static string _globalFilmID = "0";//filmID
       public static string globalFilmID//makes a global variable for filmID 
        {
            get { return _globalFilmID; }//gets string from local variable for player 1's username 
            set { _globalFilmID = value; }//assigns string to global variable
        }
    }
}
