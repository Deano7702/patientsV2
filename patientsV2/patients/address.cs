using System;
using System.Collections.Generic;
using System.Text;

namespace patients
{
    /// <summary>
    /// Address class is a blueprint for create address objects for people and to record their address; specifically street and city
    /// </summary>
    class address
    {
        //Class fields
        private string _addressStreet;
        private string _addressCity;

        /// <summary>
        /// Constructor, initializes class fields
        /// </summary>
        /// <param name="addressStreet">Stores patients street address</param>
        /// <param name="addressCity">Stores patients city address</param>
        public address(string addressStreet, string addressCity)
        {
            _addressStreet = addressStreet;
            _addressCity = addressCity;
        }

        /// <summary>
        /// Getter and setter methods for clients street address
        /// </summary>
        public string Street { get => _addressStreet; set => _addressStreet = value; }
        /// <summary>
        /// Getter and setter methods for clients city address
        /// </summary>
        public string City { get => _addressCity; set => _addressCity = value; }
    }
}
