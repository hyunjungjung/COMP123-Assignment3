using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
        /*
         * Author: Joanne (Hyunjung) Jung
         * Student # : 300432364
         * Date Modified: July 6th, 2016
         * Description: TerrestrialPlanet class for Assignment 3
         * Version: 0.0.1 - Initial commit
         */
namespace COMP123_Assignment3
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
        {
            throw new System.NotImplementedException();
        }

        public bool Habitable()
        {
            throw new System.NotImplementedException();
        }

        public bool HassMoons()
        {
            throw new System.NotImplementedException();
        }
    }
}