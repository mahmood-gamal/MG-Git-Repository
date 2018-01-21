using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCorePPv2.Models
{
    public class Dwarf:Player
    {
        public Dwarf():base()
        {
            Strength += 5;
        }
    }
}
