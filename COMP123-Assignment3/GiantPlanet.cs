using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
        /*
         * Author: Joanne (Hyunjung) Jung
         * Student # : 300432364
         * Date Modified: July 7th, 2016
         * Description: GiantPlanet class for Assignment 3
         * Version: 0.0.3 - Implemented GiantPlanet and TerrestrialPlanet to create giantPlanet and terristrialPlanet object
         * and WaitForAnyKey method in Main Method
         */
namespace COMP123_Assignment3
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _type;

        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This constructor Method takes all parameters of the Planet base class as well as type as a local variable
        * and set the related instance variable
        * </summary>
        * 
        * @constructor GiantPlanet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
        * @param {string} type
        */
        public GiantPlanet(string name, double diameter, double mass, string type) 
            :base(name, diameter, mass)
        {
            this._type = type;
        }

        // PUBLIC METHOD ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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
         /**
          * <summary>
          * This method returns true if the HasRings property is creater than zero
          * </summary>
          * 
          * @method HasRings
          * @returns {bool}
          */
        public bool HasRings()
        {
            if (RingCount < 0)
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