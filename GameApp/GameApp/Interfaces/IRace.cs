using GameApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameApp.Interfaces
{
    interface IRace:IName
    {
        Race race { get; set; }
        Profession profession { get; set; }
    }
}
