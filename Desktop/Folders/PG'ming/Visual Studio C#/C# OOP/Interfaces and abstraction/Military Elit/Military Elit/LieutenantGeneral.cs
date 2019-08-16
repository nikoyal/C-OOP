using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit
{
    interface LieutenantGeneral : Soldier
    {
        List<string> Privates { get; set; }
    }
}
