using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
        /*
         * Author: Joanne (Hyunjung) Jung
         * Student # : 300432364
         * Date Modified: July 7th, 2016
         * Description: TerrestrialPlanet class for Assignment 3
         * Version: 0.0.3 - Implemented GiantPlanet and TerrestrialPlanet to create giantPlanet and terristrialPlanet object
         * and WaitForAnyKey method in Main Method
         */
namespace COMP123_Assignment3
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private bool _oxygen;

        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This constructor Method takes all parameters of the Planet base class as well as oxygen as a local variable
        * and set the related instance variable
        * </summary>
        * 
        * @constructor GiantPlanet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
        * @param {string} oxygen
        */
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        // PUBLIC METHOD ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method returns true if the Habitable property has oxygen 
         * </summary>
         * 
         * @method Habitable
         * @returns {bool}
         */ 
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
        /**
         * <summary>
         * This method returns true if the MoonCount property is creater than zero
         * </summary>
         * 
         * @method HasMoons
         * @returns {bool}
         */
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