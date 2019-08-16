using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson,IIdentifiable,IBirthable
    {
        public Citizen(string name, int age,string id,string birthdate)
        {
            this.birthdate = birthdate;
            this.id = id;
            this.name = name;
            this.age = age;
        }
        string birthdate;
        string id;
        string name;
        int age;


        string IPerson.Name { get => name; set => name = value; }
        int IPerson.Age { get => age; set => age = value; }
        public string Id { get => id; set => id = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
    }
}
