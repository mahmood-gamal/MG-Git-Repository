using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCorePPv2.Models
{
    public class Human:Player
    {
        public Human() : base()
        {
            Intelligence += 5;
        }
    }
}
