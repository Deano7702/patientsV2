using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace patients
{
    /// <summary>
    /// Date: 13/07/2022
    /// Creator: Dean Mason
    /// Desc: Program reads data objects from a JSON file and creates patient objects to store relevant information, which is displayed to the console
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> peopleList = new List<Person>(); //List to store people 
            List<Address> addressList = new List<Address>(); //List to store address'

            try
            {
                dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(@"contactDetails.json")); // Read data from JSON file

                    if (jsonFile != null)
                    {
                        foreach (var contact in jsonFile) //For each JSON data object
                        {
                            //Store data in respective variables
                            var fullName = (string)contact["full_name"];
                            var mobile = (string)contact["mobile"];
                            var street = (string)contact["address"]["street"];
                            var city = (string)contact["address"]["city"];

                            var p = new Person(fullName, mobile); //Create a new patient object with data
                            var a = new Address(street, city); //Create a new address object with data

                            peopleList.Add(p); //Add patient to the patients list
                            addressList.Add(a); //Add address to the address list
                        }
                    }

                for (int i = 0; i < addressList.Count; i++)
                {
                    Console.WriteLine("Full Name: " + peopleList[i].FullName + "\nMobile: " + peopleList[i].Mobile + "\nStreet: " + addressList[i].AddressStreet + "\nCity: " + addressList[i].AddressCity + "\n"); //Display respective information to console
                }    
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured retrieving data or the file was not found."); //Prompt error message to console
            }
        }
    } 
}
