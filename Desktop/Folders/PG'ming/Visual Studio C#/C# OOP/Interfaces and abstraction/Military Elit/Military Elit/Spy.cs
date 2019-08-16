using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    public class Spy : Soldier
    {
        public Spy(int code, string id,string name,string lastname)
        {
            Code = code;
            Id = id;
            FirstName = name;
            LastName = lastname;

        }
        public int Code { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
