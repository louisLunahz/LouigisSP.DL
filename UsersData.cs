using System;
using LouigisSP.BO;
using System.Collections.Generic;

namespace LouigisSP.DL
{
    public static class UsersData
    {

         static List<Person> persons = new List<Person>();
        public static List<Person> GetAllUsers()
        {
            persons.Clear();
            Person emp = new Employee(123, "jose", "Luna", "2221989689", "louislunahz@gmail.com", "123123", new DateTime(2010,03,03), new DateTime(1987,12,01));
            Person emp2 = new Employee(124, "Carl", "Jonson", "2211207149", "carljohnson@gmail.com", "12345", new DateTime(1997,12,12), DateTime.Now);
            Person customer = new Customer(124, "Tyler", "Durden", "2212323445", "tylerdurden@gmail.com", "password", new DateTime(1996-08-19), DateTime.Now, "Ignacio Allende 12911 Guadalupe HIdalgo", "Ignacio Allende 12991 Guadalupe HIdalgo");
            persons.Add(emp);
            persons.Add(emp2);
            persons.Add(customer);

            return persons;
        }

        public static bool AddPerson(Person person) {
            if (person != null)
            {
                persons.Add(person);
                return true;
            }
            else return false;  
            
            

        }


    }
}
