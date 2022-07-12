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

            List<person> PeopleList = new List<person>(); //List to store people 
            List<address> AddressList = new List<address>(); //List to store address'
            int counter = 0; //Counter to increment through JSON data objects

            try
            {
                dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(@"contactDetails.json")); // Read data from JSON file

                foreach (var contact in jsonFile) //For each JSON data object
                {
                    //Store data in respective variables
                    string full_name = (string)jsonFile[counter]["full_name"];
                    string mobile = (string)jsonFile[counter]["mobile"];
                    string street = (string)jsonFile[counter]["address"]["street"];
                    string city = (string)jsonFile[counter]["address"]["city"];

                    person p = new person(full_name, mobile); //Create a new patient object with data
                    address a = new address(street, city); //Create a new address object with data

                    PeopleList.Add(p); //Add patient to the patients list
                    AddressList.Add(a); //Add address to the address list

                    counter++;
                }

                for (int i = 0; i < AddressList.Count; i++)
                {
                    Console.WriteLine("Full Name: " + PeopleList[i].FullName + "\nMobile: " + PeopleList[i].Mobile + "\nStreet: " + AddressList[i].Street + "\nCity: " + AddressList[i].City + "\n"); //Display respective information to console
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured retrieving data or the file was not found."); //Prompt error message to console
            }
        }
    } 
}
