using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    interface Private : Soldier
    {
        decimal Salary { get; set; }
    }
}
