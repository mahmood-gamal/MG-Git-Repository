using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameApp.Models
{
    public class Human:Player
    {
        public Human() : base()
        {
            Intelligence += 5;
        }
    }
}
