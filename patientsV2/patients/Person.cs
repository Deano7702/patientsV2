using System;
using System.Collections.Generic;
using System.Text;

namespace patients
{
    /// <summary>
    /// Person class is a blueprint for create person objects and to record their full name and mobile number
    /// </summary>
    class Person
    {
        //Class fields
        public string FullName { get; set; }
        public string Mobile { get; set; }

        /// <summary>
        /// Constructor, initializes class fields
        /// </summary>
        /// <param name="name">Stores patients full name</param>
        /// <param name="number">Stores patients mobile number</param>
        public Person(string name, string number)
        {
            FullName = name;
            Mobile = number;
        }
    }
}
