﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CharactersCrud.Elements
{
    public enum MagicT
    { 
        Water,
        Fire,
        Earth,
        Air
    }

    public enum MagicA
    {
        ArcaneSignet,
        TalismanOfDominance,
        MindStone,
        GildedLotus,

    }

    [Serializable]
   class Magician : Character
        
    {
       

        public MagicT MagicT { get; set; }
        public MagicA MagicA { get; set; }
        public Magician(MagicT magicType, MagicA magicArtefacts,string name, int age, int level, int health, Race race) : base(name, age, level, health, race)
        {
            MagicT = magicType;

            MagicA = magicArtefacts;


        }

    }


    [Serializable]
    class Summoner : Magician
    {
        public Summoner(MagicT magicType, MagicA magicArtefacts,string name, int age, int level, int health, Race race ) : base(magicType, magicArtefacts,name, age, level, health,race)
        {
         
        

        }

       
    }
}