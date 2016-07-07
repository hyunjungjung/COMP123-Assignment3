using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
        /*
         * Author: Joanne (Hyunjung) Jung
         * Student # : 300432364
         * Date Modified: July 7th, 2016
         * Description: Planet class for Assignment 3
         * Version: 0.0.4 - Final commit
         */
namespace COMP123_Assignment3
{
    /**
    * This class defines a generic Planet
    * 
    * @class Planet
    * @field {double} _diameter
    * @field {double} _mass
    * @field {int} _moonCount
    * @field {string} _name
    * @field {double} _orbitalPeriod
    * @field {int} _ringCount
    * @field {double} _rotationPeriod
    */
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is a property for our _diameter field
        * </summary>
        * @property {double} Diameter
        */
        public double Diameter
        {
            get { return this._diameter; }
        }
        /**
        * <summary>
        * This is a property for our _mass field
        * </summary>
        * @property {double} Mass
        */
        public double Mass
        {
            get { return this._mass; }
        }
        /**
        * <summary>
        * This is a property for our _moonCount field
        * </summary>
        * @property {int} MoonCount
        */
        public int MoonCount
        {
            get { return this._moonCount; }
            set { this._moonCount = value; }
        }
        /**
        * <summary>
        * This is a property for our _name field
        * </summary>
        * @property {string} Name
        */
        public string Name
        {
            get { return this._name; }
        }
        /**
        * <summary>
        * This is a property for our _orbitalPeriod field
        * </summary>
        * @property {double} OrbitalPeriod
        */
        public double OrbitalPeriod
        {
            get { return this._orbitalPeriod; }
            set { this._orbitalPeriod = value; }
        }
        /**
        * <summary>
        * This is a property for our _ringCount field
        * </summary>
        * @property {int} RingCount
        */
        public int RingCount
        {
            get { return this._ringCount; }
            set { this._ringCount = value; }
        }
        /**
        * <summary>
        * This is a property for our _rotationPeriod field
        * </summary>
        * @property {double} RotationPeriod
        */
        public double RotationPeriod
        {
            get { return this._rotationPeriod; }
            set { this._rotationPeriod = value; }
        }
        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This constructor takes name, diameter and mass as parameters
         * and passes them to the Private Instance Variables
         * </summary>
         * 
         * @constructor Planet
         * @param {string} name
         * @param {double} diameter
         * @param {double} mass
         */ 
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;

        }
        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method outputs Name, Diameter and Mass to the console
         * </summary>
         * 
         * @method ToString()
         * @return {string} 
         */ 
        public override string ToString()
        {
            return string.Format("Name : {0}\nDiameter : {1:E2} km\nMass : {2:E2} kg\n", this.Name, this.Diameter, this.Mass);

        }
    }
}