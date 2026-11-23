using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Director
    {
        /*
         * 11a. feladat
         *  property: string Name
         */

        public string Name { get; set; }
        public Director(string name) 
        {
            Name = name;
        }
    }
}
