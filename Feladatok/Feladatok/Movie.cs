using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Movie
    {
        /*
         * 11b. feladat
         * 
         * PROPERTYK
         *      - string Title
         *      - int Length
         *      - Director Directo
         * 
         */

        public string Title { get; set; }
        public int Length { get; set; }
        public Director Directo { get; set; }
        public Movie(string title, int length, Director directo) 
        {
            Title = title;
            Length = length;
            Directo = directo;
        }
    }
}
