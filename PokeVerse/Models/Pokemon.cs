﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeVerse.Models
{
    public class PokemonModel : BaseEntity
    {
  
        public string Name { get; set; }

        public string Type0 { get; set; }

        public string Type1 { get; set; }

        public int HP { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int Speed { get; set; }

        public PokemonModel(string name, string type0, string type1, int hp, int attack, int defense, int speed)
        {
            Name = name;
            Type0 = type0;
            Type1 = type1;
            HP = hp;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            
        }

    }
}
