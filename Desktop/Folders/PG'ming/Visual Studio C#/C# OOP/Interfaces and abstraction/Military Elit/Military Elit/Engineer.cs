using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public class Engineer : SpecialisedSoldier
    {
        public Engineer(string corp,decimal salary,string id,string firstname,string lastname,string part,int work)
        {
            Corp = corp;
            Salary = salary;
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            part = Part;
            work = Work;
        }

        public string Corp { get; set; }
        public decimal Salary { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set ; }
        public string LastName { get; set; }

        public string Part { get; set; }
        public int Work { get; set; }
    }
}
