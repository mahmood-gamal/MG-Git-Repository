using GameApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameApp.Models
{
    public class Player : IAttributes, IName, IRace
    {
        public Player()
        {
            Strength = 5;
            Agility = 5;
            Intelligence = 5;
            Hp = 100;
            Level = 1;
        }
        public string _name { get; set; }
        public int Level { get; set; }
        public long ExpPoints { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        private Race _race;
        public int Hp
        {
            get;
            set;
            //get { return Hp; }
            //set
            //{
            //    if (value <= 0) Hp = 0;
            //    else if (value > 100) Hp = 100;
            //    else Hp = value;
            //}
        }
        public Race race {
            get {
                switch (_race)
                {
                    case Race.Human:
                        Intelligence += 5;
                        break;
                    case Race.Elf:
                        Agility += 5;
                        break;
                    case Race.Dwarf:
                        Strength += 5;
                        break;
                    default:
                        break;
                }
                return _race;
            }
            set { _race = value; }
        }
        public Profession profession{ get; set; }
    }
}
