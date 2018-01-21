using NetCorePPv2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCorePPv2.Models
{
    public class Player:IAttributes, IName
    {
        protected Player()
        {
            Strength = 5;
            Agility = 5;
            Intelligence = 5;
            Hp = 100;
            Level = 1;
        }
        public string _name { get; set; }
        public int Level{ get; set; }
        public long ExpPoints { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int Hp
        {
            get { return Hp; }
            set
            {
                if (value <= 0) Hp = 0;
                else if (value > 100) Hp = 100;
                else Hp = value;
            }
        }
    }
}
