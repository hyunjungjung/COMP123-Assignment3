using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
        /*
         * Author: Joanne (Hyunjung) Jung
         * Student # : 300432364
         * Date Modified: July 7th, 2016
         * Description: TerrestrialPlanet class for Assignment 3
         * Version: 0.0.2 - Added private instance variables, public methods and constructors to classes
         */
namespace COMP123_Assignment3
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}