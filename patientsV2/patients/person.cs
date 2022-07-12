using System;
using System.Collections.Generic;
using System.Text;

namespace patients
{
    /// <summary>
    /// person class is a blueprint for create person objects and to record their full name and mobile number
    /// </summary>
    class person
    {
        //Class fields
        private string _fullName;
        private string _mobile;

        /// <summary>
        /// Constructor, initializes class fields
        /// </summary>
        /// <param name="fullName">Stores patients full name</param>
        /// <param name="mobile">Stores patients mobile number</param>
        public person(string fullName, string mobile)
        {
            _fullName = fullName;
            _mobile = mobile;
        }

        /// <summary>
        /// Getter and setter methods for clients full name
        /// </summary>
        public string FullName { get => _fullName; set => _fullName = value; }
        /// <summary>
        /// Getter and setter methods for clients mobile
        /// </summary>
        public string Mobile { get => _mobile; set => _mobile = value; }
    }
}
