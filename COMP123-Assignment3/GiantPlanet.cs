using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
        /*
         * Author: Joanne (Hyunjung) Jung
         * Student # : 300432364
         * Date Modified: July 6th, 2016
         * Description: GiantPlanet class for Assignment 3
         * Version: 0.0.1 - Initial commit
         */
namespace COMP123_Assignment3
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        public GiantPlanet(string name, double diameter, double mass, string type) 
            :base(name, diameter, mass )

        }

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }

        public bool HasRings()
        {
            throw new System.NotImplementedException();
        }
    }
}