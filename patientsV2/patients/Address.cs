using System;
using System.Collections.Generic;
using System.Text;

namespace patients
{
    /// <summary>
    /// Address class is a blueprint for create address objects for people and to record their address; specifically street and city
    /// </summary>
    class Address
    {
        //Class fields
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }

        /// <summary>
        /// Constructor, initializes class fields
        /// </summary>
        /// <param name="street">Stores patients street address</param>
        /// <param name="city">Stores patients city address</param>
        public Address(string street, string city)
        {
            AddressStreet = street;
            AddressCity = city;
        }
    }
}
