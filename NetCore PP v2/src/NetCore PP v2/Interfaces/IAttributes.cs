using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCorePPv2.Interfaces
{
    interface IAttributes
    {
        int Strength { get; set; }
        int Agility { get; set; }
        int Intelligence { get; set; }
        int Hp { get; set; }
    }
}
